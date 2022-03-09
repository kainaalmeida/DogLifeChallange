using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace DogLifeChallange.ViewModels
{
    public class RegisterPageViewModel : ViewModelBase
    {

        private IAsyncCommand _loginCommand;
        public IAsyncCommand LoginCommand
            => _loginCommand ?? (_loginCommand = new AsyncCommand(ExecuteLoginCommand, allowsMultipleExecutions: false));

        public RegisterPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        private async Task ExecuteLoginCommand()
            => await NavigationService.GoBackAsync();
    }
}
