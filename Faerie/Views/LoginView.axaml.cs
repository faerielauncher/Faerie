using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CmlLib.Core.Auth.Microsoft;
using Faerie.Core.Logger;
using Faerie.Core.Player;

namespace Faerie;

public partial class LoginView : UserControl
{
    JELoginHandler loginHandler = new JELoginHandlerBuilder()
        .WithLogger(FaerieLogger.logger)
        .Build();
    public LoginView()
    {
        InitializeComponent();
    }

    private async void Login_OnClick(object? sender, RoutedEventArgs e)
    {
        FaerieAuth auth = new(loginHandler, "419a9423-d567-45c6-97ca-2c06ae3468b2");

        var msal = auth.Prepare();

        await auth.Signin(msal.Result.authenticator);
        var player = auth.GetPlayer();

        if (player is null)
        {
            throw new Exception("Couldn't fetch player data!");
        }

        Debug.WriteLine(player.GetUsername());


    }
}