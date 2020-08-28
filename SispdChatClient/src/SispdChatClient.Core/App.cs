using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SispdChatClient.Core.ViewModels.Root;

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

            RegisterAppStart<RootViewModel>();
        }
    }
}
