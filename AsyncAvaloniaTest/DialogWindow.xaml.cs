using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AsyncAvaloniaTest
{
    public class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}