namespace UFV_Conversor;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for navigation
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(PasswordRecoveryPage), typeof(PasswordRecoveryPage));
        Routing.RegisterRoute(nameof(ConversorPage), typeof(ConversorPage));
        Routing.RegisterRoute(nameof(UserInfoPage), typeof(UserInfoPage));
    }
}