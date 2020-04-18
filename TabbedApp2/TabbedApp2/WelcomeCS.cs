using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedApp2
{
	public class WelcomeCS : ContentPage
	{
		public WelcomeCS ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to DNR driving app!" }
				}
			};
		}
	}
}