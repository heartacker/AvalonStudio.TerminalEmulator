// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvalonStudio.TerminalEmulator.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AvalonStudio.TerminalEmulator
{
    public class ViewLocator : IDataTemplate
    {
        public Control? Build(object? param)
        {
            if (param is null) return null;
            var name = param.GetType().Name!.Replace("ViewModel", "");
            var type = Type.GetType("VariableBox.Demo.Pages." + name);
            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object? data)
        {
            return true;
        }
    }
}