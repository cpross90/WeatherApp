using Weather.Services;

namespace Weather.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private WeatherApi _api;
        public MainWindowViewModel(WeatherApi api)
        {
            _api = api;
        }
    }
}
