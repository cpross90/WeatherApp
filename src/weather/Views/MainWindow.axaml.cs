using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using Weather.Services;

namespace weather
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}