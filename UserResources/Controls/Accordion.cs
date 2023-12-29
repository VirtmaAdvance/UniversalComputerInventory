using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalComputerInventory.Services.Extensions.Objects;

namespace UniversalComputerInventory.UserResources.Controls
{
	public class Accordion : AbsoluteLayout
	{

		private string _text;
		public string Text
		{
			get => _text;
			set
			{
				_text=value;
				TitleLabel=CreateLabelElement(value);
			}
		}
		private Label? _titleLabel;

		public Label? TitleLabel
		{
			get => _titleLabel;
			protected set => SetTitleLabel(value);
		}



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