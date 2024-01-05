using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalComputerInventory.Services.Extensions.Enumerations;
using UniversalComputerInventory.Services.Extensions.Objects;

namespace UniversalComputerInventory.UserResources.Controls
{
	public class Accordion : AbsoluteLayout
	{

		private string _text="";
		/// <summary>
		/// The header text of this control.
		/// </summary>
		public string Text
		{
			get => _text;
			set
			{
				_text=value;
				TitleLabel=CreateLabelElement(value);
			}
		}
		private Button? _titleLabel;

		public Button? TitleLabel
		{
			get => _titleLabel;
			protected set => SetTitleLabel(value);
		}
		/// <summary>
		/// Indicates if this control is in it's expanded or collapsed visual state.
		/// </summary>
		public bool IsExpanded { get; private set; } = false;


		/// <summary>
		/// Creates a new instance of the <see cref="Accordion"/> control.
		/// </summary>
		/// <param name="text"></param>
		public Accordion(string text)
		{
			Text=text;
		}

		protected static Label CreateLabelElement(string text)
		{
			return new Label()
			{
				Text=text,
				StyleId="AccordionTitleLabel"
			};
		}

		protected static Button CreateButtonElement(string text)
		{
			var btn=new Button()
			{
				Text=text,
			};
			btn.Clicked+=Btn_Clicked;
			return btn;
		}

		private static void Btn_Clicked(object? sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		public void Expand()
		{

		}
		/// <summary>
		/// Determines the inner content height this control should be set to.
		/// </summary>
		/// <returns></returns>
		private double GetInnerHeight()
		{
			return Children.Cast<View>().IterateMathDouble((control, height) => Math.Max(height, GetControlMaxTop(control)));
			//double height = 0;
			//foreach(var sel in Children.Cast<View>())
			//	height=Math.Max(height, GetControlMaxTop(sel));
			//return height;
		}

		private static VSize GetControlYDepth(View control)
		{
			VSize parentPadding=GetParentPadding(control);
			return new VSize(GetControlMaxLeft(control)+parentPadding.Width, GetControlMaxTop(control)+parentPadding.Height);
		}

		private static double GetControlMaxLeft(View control) => Max(control.Width, control.Bounds.Width) + control.Margin.Left + control.TranslationX;

		private static double GetControlMaxTop(View control) => Max(control.Height, control.Bounds.Height) + control.Margin.Top + control.TranslationY;

		private static VSize GetControlMargin(View control) => new (control.Margin.Left, control.Margin.Top);

		private static VSize GetControlOffset(View control) => new (control.TranslationX, control.TranslationY);

		private static double Max(double a, double b) => Math.Max(a, b);

		private static VSize GetParentPadding(View control)
		{
			var parent=control.Parent;
			return parent is Layout parentLayout ? new VSize(parentLayout.Padding.Left, parentLayout.Padding.Top) : new VSize(0, 0);
		}

		private void SetTitleLabel(Label? label)
		{
			if(label is not null)
			{
				if(_titleLabel is null)
				{
					_titleLabel=label;
					Add(label);
				}
				else
					CopyLabels(label, _titleLabel);
			}
		}

		private static void CopyLabels(Label from, Label to) => from.Copy(to);

	}
}