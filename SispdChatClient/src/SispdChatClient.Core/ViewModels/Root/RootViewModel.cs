using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using SispdChatClient.Core.ViewModels.Home;
using SispdChatClient.Core.ViewModels.Menu;

namespace SispdChatClient.Core.ViewModels.Root
{
    public class RootViewModel : BaseViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        public override async void ViewAppearing()
        {
            base.ViewAppearing();

            await _navigationService.Navigate<MenuViewModel>();
            await _navigationService.Navigate<HomeViewModel>();
        }
    }
}
