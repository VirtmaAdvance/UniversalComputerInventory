﻿namespace UniversalComputerInventory
{
	public partial class MainPage:ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();

			PrepareInfo();

		}


		private void PrepareInfo()
		{
			ComputerNameInput.Text=Environment.MachineName;
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			//count++;
			//if(count == 1)
			//	CounterBtn.Text = $"Clicked {count} time";
			//else
			//	CounterBtn.Text = $"Clicked {count} times";
			//SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}

}
