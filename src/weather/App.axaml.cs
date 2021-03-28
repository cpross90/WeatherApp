using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Weather.Services;
using Weather.ViewModels;

namespace weather
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            const string? API_VAR = "WEATHER_API_KEY";

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                string? apiKey = Environment.GetEnvironmentVariable(API_VAR);
                
                var api = new WeatherApi(apiKey);
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(api)
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}