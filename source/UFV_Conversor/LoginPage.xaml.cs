using Microsoft.Maui.Controls;
namespace UFV_Conversor;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        if (UsernameEntry.Text == "" || PasswordEntry.Text == "") {
            await DisplayAlert("Login Failed", "Please enter both username and password.", "OK");
        }

        string filePath = "files/users.csv";

        bool found = false;
        if (File.Exists(filePath)) {
            foreach (string line in File.ReadAllLines(filePath)) {
                string[] fields = line.Split(';');
                if (fields[1] == UsernameEntry.Text && fields[3] == PasswordEntry.Text)
                    found = true;
            }
        }

        if (found)
            await Shell.Current.GoToAsync($"{nameof(ConversorPage)}?username={UsernameEntry.Text}");
        else
            await DisplayAlert("Login Failed", "Account does not exist or password is incorrect.", "OK");
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PasswordRecoveryPage));
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}