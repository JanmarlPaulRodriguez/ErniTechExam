using System;
using System.Windows.Input;
using ErniTechExam.Models;
using Prism.Commands;
using Prism.Navigation;

namespace ErniTechExam.ViewModels
{
    public class UserDetailsViewModel : BaseViewModel
    {
        #region --[Fields]--
        private UserModel user;
        #endregion

        public UserDetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            BackCommand = new DelegateCommand(OnBackCommand);
        }

        #region --[Properties]--
        public UserModel User
        {
            get => user;
            set => SetProperty(ref user, value);
        }
        #endregion

        #region --[Commands]--
        public ICommand BackCommand { get; }
        #endregion

        #region --[Functions]--
        private void OnBackCommand()
        {
            _navigationService.GoBackAsync();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if(parameters.ContainsKey(nameof(UserModel)))
            {
                User = parameters[nameof(UserModel)] as UserModel;
            }
        }
        #endregion
    }
}
