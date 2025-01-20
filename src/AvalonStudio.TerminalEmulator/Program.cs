using System;
using Avalonia;
using Avalonia.Dialogs;
using Avalonia.Logging;
using Avalonia.Media;
using Avalonia.ReactiveUI;
using AvalonStudio.TerminalEmulator.ViewModels;
using AvalonStudio.TerminalEmulator.Views;
using AvalonStudio.Terminals.Unix;

namespace AvalonStudio.TerminalEmulator;


class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .With(new FontManagerOptions
        {
            FontFallbacks = new[]
            {
                new FontFallback
                {
                    FontFamily = new FontFamily("Microsoft YaHei")
                }
            }
        })
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UseManagedSystemDialogs()
            .UsePlatformDetect()
            .With(new Win32PlatformOptions())
            .LogToTrace();
}

