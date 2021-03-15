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
    public partial class SignUp2 : ContentPage
    {
        public SignUp2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Cliked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VerifyEmail());
        }

        private void btnLogin_Cliked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login2 ());

        }
    }
}