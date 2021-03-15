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
    public partial class Login1Fingerprint : ContentPage
    {
        public Login1Fingerprint()
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
            Navigation.PushModalAsync(new Login2());

        }

        private void btnloginwithyouremail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login2());
        }

        private void btnsignupl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp2());
        }
    }
}