using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace danielinfo
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("im.jpg");
            AboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItemsPage> GetMenuList()
        {
            var list = new List<MasterMenuItemsPage>();
            list.Add(new MasterMenuItemsPage()
            {
                Text = "Minust",
                Detail = "Lühike info",
                ImagePath = "hot.png",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItemsPage()
            {
                Text = "Minu Kogemus",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "ham.png",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItemsPage()
            {
                Text = "Minu oskused",
                Detail = "Natuke rohkem minu oskustest",
                ImagePath = "fish.png",
                TargetPage = typeof(Views.SkillsPage)

            });
            list.Add(new MasterMenuItemsPage()
            {
                Text = "Minu võidud",
                Detail = "Ma olen uhke!!!",
                ImagePath = "chicken.png",
                TargetPage = typeof(Views.AchievmnetsPage)
            });
            return list;

        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItemsPage)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;

        }
    }
}
