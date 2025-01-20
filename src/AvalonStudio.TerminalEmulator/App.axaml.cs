using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvalonStudio.TerminalEmulator.ViewModels;
using AvalonStudio.TerminalEmulator.Views;

namespace AvalonStudio.TerminalEmulator;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow()
            {
                DataContext = new TerminalViewModel(),
                Height = 720,
                Width = 960,
            };
        }
        //else if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
        //{
        //    singleView.MainView = new MainView() { DataContext = new MainViewViewModel() };
        //}

        base.OnFrameworkInitializationCompleted();
    }
}