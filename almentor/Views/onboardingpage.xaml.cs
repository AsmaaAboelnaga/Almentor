using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace almentor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class onboardingpage : ContentPage
    {
        public class UserInformation
        {
            public ImageSource UserImage { get; set; }
            public string Content { get; internal set; }
            public string Title { get; internal set; }
        }
        private ObservableCollection<UserInformation> userCollection;
        public ObservableCollection<UserInformation> UserCollection
        {
            get { return userCollection; }
            set
            {
                userCollection = value;
                OnPropertyChanged();
            }
        }
        public onboardingpage()
        {
            InitializeComponent();
            BindingContext = this;
            UserCollection = new ObservableCollection<UserInformation>
            {
                new UserInformation{UserImage="almentoricon", Title = "Learn online", Content = "Progress faster, develop more"},
                 new UserInformation{UserImage="correctionmark", Title = "Learn anywhere anytime", Content ="We offer online courses that you can access anywhere and anytime, from web or mobile."},
                 new UserInformation{UserImage="fingerprint",Title = "Receive Certificates", Content ="Once you finish a course, you will receive as certificate of completion."},
                 new UserInformation{UserImage="playerlogoalmentordark", Title = "Ask your mentor", Content ="Get the chance to ask the  course mentor questions and have them answer back."}
            };
        }

        private void btngetstarted_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login1());

        }

        private void btnskip_Clicked(object sender, EventArgs e)
        {

        }
        private void CarouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            //CarouselView_Scrolled.ScrollTo(monkey, position: (ScrollToPosition)enumPicker.SelectedItem, animate: animateSwitch.IsToggled);
            //Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
            //Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
            //Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
            //Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
            //Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
            //Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
            //Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
           // carouselView.ScrollTo(monkey, position: ScrollToPosition.MakeVisible);
        }


    }
}