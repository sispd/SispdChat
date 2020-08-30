using SispdChatClient.Service;

namespace SispdChatClient.Core.ViewModels
{
    public class RootViewModel : BaseViewModel
    {
        #region Services
        private readonly ITestService _testService;
        #endregion

        #region Properties
        private string testStr;
        public string TestStr
        {
            get => testStr;
            set => SetProperty(ref testStr, value);
        }
        #endregion


        public RootViewModel(ITestService testService)
        {
            _testService = testService;
            TestStr = _testService.GetTestStr();
        }


    }
}
