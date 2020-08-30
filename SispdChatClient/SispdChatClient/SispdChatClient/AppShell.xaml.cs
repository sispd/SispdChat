using System;
using System.Collections.Generic;
using SispdChatClient.ViewModels;
using SispdChatClient.Views;
using Xamarin.Forms;

namespace SispdChatClient
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
