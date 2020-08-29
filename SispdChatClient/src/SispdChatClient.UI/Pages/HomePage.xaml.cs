using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using SispdChatClient.Core.ViewModels.Home;
using Xamarin.Forms.Xaml;

namespace SispdChatClient.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxTabbedPagePresentation(TabbedPosition.Root, NoHistory = true)]
    public partial class HomePage : MvxTabbedPage<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }
}