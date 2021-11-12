using System;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace ErniTechExam.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IPageLifecycleAware, IDestructible
    {
        public INavigationService _navigationService;

        public BaseViewModel()
        {
        }

        public void Destroy()
        {;
        }

        public void OnAppearing()
        {
        }

        public void OnDisappearing()
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
