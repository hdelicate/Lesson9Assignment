using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedApp2
{
	public class CreditsCS : ContentPage
	{
		public CreditsCS ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Credits" }
				}
			};
		}
	}
}