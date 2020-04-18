using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedApp2
{
	public class CalculateCS : ContentPage
	{
		public CalculateCS ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Calculate your how long you have been driving" }
				}
			};
		}
	}
}