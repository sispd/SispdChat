using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SispdChatClient.Core.ViewModels.Home;
using SispdChatClient.Core.ViewModels.Login;
using SispdChatClient.Service;
using SispdChatClient.Service.Implements;
using System;

namespace SispdChatClient.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            InitServices();

            var isLogined = false;

            if(isLogined)
                RegisterAppStart<HomeViewModel>();
            else
                RegisterAppStart<LoginViewModel>();
        }

        private void InitServices()
        {
            Mvx.IoCProvider.ConstructAndRegisterSingleton<ITestService, TestService>();
        }
    }
}
