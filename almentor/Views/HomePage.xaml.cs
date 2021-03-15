using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace almentor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Xamarin.Forms.TabbedPage
    {
        public class RecmmendedForYou
        {
            public ImageSource UserImage { get; set; }
            public string Title { get; internal set; }
        }
        private ObservableCollection<RecmmendedForYou> userCollection;
        public ObservableCollection<RecmmendedForYou> UserCollection
        {
            get { return userCollection; }
            set
            {
                userCollection = value;
                OnPropertyChanged();
            }
        }
  


        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            UserCollection = new ObservableCollection<RecmmendedForYou>
            {
                new RecmmendedForYou{UserImage="home", Title = "Business Plan Writing for Eng..."},
                 new RecmmendedForYou{UserImage="hom", Title = "Tips for Positive Parenting"},
                 new RecmmendedForYou{UserImage="ho",Title = "Business Plan Writing for Eng..."},
                 new RecmmendedForYou{UserImage="home", Title = "Ask your mentor"},
                 new RecmmendedForYou{UserImage="hom", Title = "Ask your mentor"},
                 new RecmmendedForYou{UserImage="ho", Title = "Ask your mentor"},
                 new RecmmendedForYou{UserImage="home", Title = "Ask your mentor"}
            };
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);
        }
     
        //public List<Product> TrendsList { get => GetTrends(); }

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
        //private List<Product> GetCollections()
        //{
        //    var trendList = new List<Product>();
        //    trendList.Add(new Product { Image = "floral.png", Name = "Floral Bag + Hat", Price = "$123.50" });
        //    trendList.Add(new Product { Image = "satchel.png", Name = "Satchel Bag", Price = "$49.99" });
        //    trendList.Add(new Product { Image = "leatherBag.png", Name = "Leather Bag", Price = "$40.99" });
        //    return trendList;
        //}
    }
}