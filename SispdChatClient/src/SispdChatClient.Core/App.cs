using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SispdChatClient.Core.ViewModels.Home;

namespace SispdChatClient.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
