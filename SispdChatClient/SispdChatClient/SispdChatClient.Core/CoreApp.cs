using MvvmCross;
using MvvmCross.ViewModels;
using SispdChatClient.Core.ViewModels;
using SispdChatClient.Service;
using SispdChatClient.Service.Implements;

namespace SispdChatClient.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegistServices();

            RegisterAppStart<RootViewModel>();
        }

        public void RegistServices()
        {
            Mvx.IoCProvider.RegisterType<ITestService, TestService>();
        }
    }
}
