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
    public partial class Login2 : ContentPage
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btnlogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HomePage());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp2());
        }

        private void btnforgotpassword_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ResetPassword1());
        }
    }
}