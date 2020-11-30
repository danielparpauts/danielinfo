using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace danielinfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuItemsPage : ContentPage
    {
        public string Text { get; set; }

        public string Detail { get; set;}

        public string ImagePath { get; set;}

        public Type TargetPage { get; set; }
    }
}