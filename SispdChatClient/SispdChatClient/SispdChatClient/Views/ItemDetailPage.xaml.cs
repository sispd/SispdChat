using System.ComponentModel;
using Xamarin.Forms;
using SispdChatClient.ViewModels;

namespace SispdChatClient.Views
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