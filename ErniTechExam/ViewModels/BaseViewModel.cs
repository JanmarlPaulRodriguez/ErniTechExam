using System;
using ErniTechExam.Services.Interfaces;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace ErniTechExam.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IPageLifecycleAware, IDestructible
    {
        public IPageDialogService _pageDialogService;
        public INavigationService _navigationService;
        public IUserService _userService;        

        public BaseViewModel()
        {
        }

        public virtual void Destroy()
        {;
        }

        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}
