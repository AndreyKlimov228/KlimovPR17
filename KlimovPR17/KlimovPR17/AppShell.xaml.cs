using KlimovPR17.ViewModels;
using KlimovPR17.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KlimovPR17
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
