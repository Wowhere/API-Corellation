using ReactiveUI;
using System.Collections.ObjectModel;

namespace api_corelation.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<string>? _Requests;
        public ObservableCollection<string>? Requests
        {
            get => _Requests;
            set => this.RaiseAndSetIfChanged(ref _Requests, value);
        }
        private bool _IsProxied;
        public bool IsProxied
        {
            get => _IsProxied;
            set => this.RaiseAndSetIfChanged(ref _IsProxied, value);
        }
    }
}
