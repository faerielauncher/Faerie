using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CmlLib.Core.Auth.Microsoft;
using Faerie.Core.Player;
using System.Diagnostics;
using System.Linq;
using CmlLib.Core.Auth.Microsoft.Sessions;

namespace Faerie.Views
{
    public partial class MainWindow : Window
    {
        readonly JELoginHandler _loginHandler = new JELoginHandlerBuilder()
            .WithLogger(logger)
            .Build();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_OnLoaded(object? sender, RoutedEventArgs e)
        {
            var faerieSession = new FaerieSession(_loginHandler);

            if (faerieSession.GetAccountCollection().Any())
            {
                JEGameAccount account = faerieSession.GetAccountCollection()[0];

            }

        }
    }
}