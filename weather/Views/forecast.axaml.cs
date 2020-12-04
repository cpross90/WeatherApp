using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace weather.Views
{
    public class forecast : UserControl
    {
        public forecast()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
