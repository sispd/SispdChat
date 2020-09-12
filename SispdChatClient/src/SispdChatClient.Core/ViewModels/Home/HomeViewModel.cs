using SispdChatClient.Service;

namespace SispdChatClient.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        ITestService TestService { get; }

        private string testStr;

        public string TestStr
        {
            get => testStr;
            set => SetProperty(ref testStr, value);
        }

        public HomeViewModel(ITestService testService)
        {
            TestService = testService;
            TestStr = testService.GetTestStr();
        }

        
    }
}
