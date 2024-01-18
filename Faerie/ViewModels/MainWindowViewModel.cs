using Faerie.Views;
using ReactiveUI;

namespace Faerie.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object _currentView;


        public object CurrentView
        {
            get { return _currentView; }
            private set { this.RaiseAndSetIfChanged(ref _currentView, value); }
        }

        public MainWindowViewModel()
        {
            _currentView = new LoginView();
        }
    }
}
