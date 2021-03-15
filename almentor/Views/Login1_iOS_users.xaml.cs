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
    public partial class Login1_iOS_users : ContentPage
    {
        public Login1_iOS_users()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void btnloginwithyouremail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login2());
        }

        private void btnsignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp2());
        }
    }
}