namespace UFV_Conversor;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ConversorPage));
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PasswordRecoveryPage));
    }
}