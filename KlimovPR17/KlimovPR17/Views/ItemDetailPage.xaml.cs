using KlimovPR17.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KlimovPR17.Views
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