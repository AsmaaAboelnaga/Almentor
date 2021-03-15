using almentor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
 
namespace almentor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void btnonboardingenglish_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new onboardingpage());
        }

        private void btnContinue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new onboardingpage());
        }
    }
}
