using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using SispdChatClient.Core;
using UIKit;

namespace SispdChatClient.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<CoreApp, FormsApp>, CoreApp, FormsApp>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            return base.FinishedLaunching(app, options);
        }
    }
}
