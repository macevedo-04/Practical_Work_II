namespace UFV_Conversor;

public partial class PasswordRecoveryPage : ContentPage
{
    public PasswordRecoveryPage()
    {
        InitializeComponent();
    }

    private async void OnRecoverClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Password Recovery", "Password recovery link sent to your email.", "OK");
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
