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
    public partial class Login1 : ContentPage
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btnfacebook_Clicked1(object sender, EventArgs e)
        {
            WebView.Source = "";
        }

        private void btngoogle_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnloginwithyouremail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login2());

        }
        //private void Button_Clicked(object sender, EventArgs e)
        //{

        //}

        private void btnsignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp2());

        }
    }
}