using DogLifeChallange.Views;
using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace DogLifeChallange.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {

        private IAsyncCommand _registerCommand;
        public IAsyncCommand RegisterCommand
            => _registerCommand ?? (_registerCommand = new AsyncCommand(ExecuteRegisterCommand, allowsMultipleExecutions: false));

        private IAsyncCommand _forgotCommand;
        public IAsyncCommand ForgotCommand
            => _forgotCommand ?? (_forgotCommand = new AsyncCommand(ExecuteForgotCommand, allowsMultipleExecutions: false));

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        private async Task ExecuteRegisterCommand()
            => await NavigationService.NavigateAsync($"{nameof(RegisterPage)}", null, useModalNavigation: true, true);

        private async Task ExecuteForgotCommand()
            => await NavigationService.NavigateAsync($"{nameof(ForgotPage)}");
    }
}
