using System;
using System.Reactive;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace AsyncAvaloniaTest
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Command = ReactiveCommand.CreateFromTask(async () =>
            {
                var dialog = new DialogWindow();
                var result = await dialog.ShowDialog<string>(this);
                Console.WriteLine("Result: " + result);
            }, outputScheduler: RxApp.MainThreadScheduler);
            DataContext = this;
            InitializeComponent();
        }

        public ReactiveCommand<Unit, Unit> Command { get; }
        
        public string Title => "Test";
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}