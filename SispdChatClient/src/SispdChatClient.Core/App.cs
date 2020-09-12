using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SispdChatClient.Core.ViewModels.Home;
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

            RegisterAppStart<HomeViewModel>();
        }

        private void InitServices()
        {
            Mvx.IoCProvider.ConstructAndRegisterSingleton<ITestService, TestService>();
        }
    }
}
