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
    public partial class SignUp1 : ContentPage
    {
        public SignUp1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnsignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp2());

        }

        private void btnlogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login2());

        }
    }
}