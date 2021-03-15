using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace almentor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Interests : ContentPage
    {
        public Interests()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ResetPassword1());

        }
    }
}