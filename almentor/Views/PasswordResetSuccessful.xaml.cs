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
    public partial class PasswordResetSuccessful : ContentPage
    {
        public PasswordResetSuccessful()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HomePage());

        }
    }
}