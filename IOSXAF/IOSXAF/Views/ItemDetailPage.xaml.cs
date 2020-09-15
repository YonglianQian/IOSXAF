using System.ComponentModel;
using Xamarin.Forms;
using IOSXAF.ViewModels;

namespace IOSXAF.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}