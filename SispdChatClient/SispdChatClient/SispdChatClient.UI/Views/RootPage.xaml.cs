using MvvmCross.Forms.Views;
using SispdChatClient.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace SispdChatClient.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : MvxContentPage<RootViewModel>
    {
        public RootPage()
        {
            InitializeComponent();
        }
    }
}