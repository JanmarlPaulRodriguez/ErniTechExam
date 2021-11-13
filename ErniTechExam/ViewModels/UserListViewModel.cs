using System;
using System.Threading.Tasks;
using ErniTechExam.Services.Interfaces;
using Prism.Navigation;
using Prism.Services;

namespace ErniTechExam.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        public UserListViewModel(INavigationService navigationService, IUserService userService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _userService = userService;
            _pageDialogService = pageDialogService;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            GetUser();
        }

        private async Task GetUser()
        {
            try
            {
                var users = await _userService.GetUsers();
                System.Console.WriteLine($"{users.Count}");
            }
            catch(Exception e)
            {
                await _pageDialogService.DisplayAlertAsync("", e.Message, "Ok");
            }
        }
    }
}
