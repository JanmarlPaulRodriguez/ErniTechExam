using System;
using Prism.Navigation;

namespace ErniTechExam.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        public UserListViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
