using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using ErniTechExam.Models;
using ErniTechExam.Services.Interfaces;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace ErniTechExam.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        #region --[Fields]--
        private bool isDataInitialized = false;
        private bool isRefreshing;
        private List<UserModel> users;
        #endregion

        public UserListViewModel(INavigationService navigationService, IUserService userService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _userService = userService;
            _pageDialogService = pageDialogService;

            ItemSelectedCommand = new DelegateCommand<UserModel>(OnItemSelectedCommand);
            RefreshCommand = new DelegateCommand(OnRefreshCommand);
        }

        #region --[Properties]--
        public bool IsRefreshing
        {
            get => isRefreshing;
            set => SetProperty(ref isRefreshing, value);
        }

        public List<UserModel> Users
        {
            get => users;
            set => SetProperty(ref users, value);
        }
        #endregion

        #region --[Commands]--
        public ICommand ItemSelectedCommand { get; }
        public ICommand RefreshCommand { get; }
        #endregion

        #region --[Functions]--
        private async Task GetUser()
        {
            IsRefreshing = true;
            try
            {
                var usersResult = await _userService.GetUsers();
                Users = usersResult;
            }
            catch (Exception e)
            {
                await _pageDialogService.DisplayAlertAsync("", e.Message, "Ok");
            }
            IsRefreshing = false;
        }        

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (!isDataInitialized)
            {
                await GetUser();
                isDataInitialized = true;
            }
        }

        private async void OnItemSelectedCommand(UserModel user)
        {
            // TODO create new page to display info
            //_navigationService.NavigateAsync()
        }

        private async void OnRefreshCommand()
        {
            if (IsRefreshing)
                return;

            await GetUser();
        }
        #endregion
    }
}
