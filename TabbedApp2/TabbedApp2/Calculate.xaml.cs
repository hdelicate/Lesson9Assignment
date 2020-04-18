using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculate : ContentPage
	{
        int ageVar;
        int ageStartedDrivingVar;
		public Calculate ()
		{
			InitializeComponent ();
            age.Completed += new EventHandler(Entry_Completed);
            ageStartedDriving.Completed += new EventHandler(AgeStartEntry_Completed);
        }
        private string myStringProperty;
        public string MyStringProperty
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
            }
        }
        void Entry_Completed(object sender, EventArgs e)
        {
             ageVar = Int32.Parse(age.Text);
        }
        void AgeStartEntry_Completed(object sender, EventArgs e)
        {
            ageStartedDrivingVar = Int32.Parse(ageStartedDriving.Text);
            label1.Text = ""+ (ageVar-ageStartedDrivingVar);
        }
      
    }
}