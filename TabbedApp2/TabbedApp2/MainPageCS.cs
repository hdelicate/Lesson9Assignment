using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TabbedApp2
{
    public class MainPageCS :TabbedPage
    {
        public MainPageCS ()
		{
			var navigationPage = new NavigationPage (new WelcomeCS ());
			navigationPage.Title = "Welcome";

			Children.Add (new CalculateCS ());
			Children.Add (navigationPage);
			Children.Add (new CreditsCS ());
		}
    }
}
