using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;
namespace UFV_Conversor;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string filePath = "files/users.csv";

        if (!TermsCheckBox.IsChecked) {
            await DisplayAlert("Register Failed", "You must accept the terms and conditions.", "OK");
            return;
        }

        if (File.Exists(filePath)) {
            foreach (string line in File.ReadAllLines(filePath)) {
                string[] fields = line.Split(';');
                if (fields[1] == UsernameEntry.Text) {
                    await DisplayAlert("Register Failed", "Username already exists.", "OK");
                    return;
                }
            }
        }

        if (ValidateFields()) {
            User user = new User(NameEntry.Text, UsernameEntry.Text, EmailEntry.Text, PasswordEntry.Text);
            user.SaveToFile(filePath);

            await DisplayAlert("Success", "Account created!", "OK");
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        else
            await DisplayAlert("Register Failed", "Please check your inputs.", "OK");
    }

    private bool ValidateFields()
    {
        string password = PasswordEntry.Text;
        string email = EmailEntry.Text;
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasLowerChar = new Regex(@"[a-z]+");
        var hasNumber = new Regex(@"[0-9]+");
        var hasSpecialChar = new Regex(@"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+");

        if (email.Contains("@") && password.Length >= 8 && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && hasNumber.IsMatch(password) && hasSpecialChar.IsMatch(password))
            return true;

        else if (NameEntry.Text == "" || UsernameEntry.Text == "" || EmailEntry.Text == "" || PasswordEntry.Text == "" || ConfirmPasswordEntry.Text == "")
            DisplayAlert("Register Failed", "Please fill all fields.", "OK");
        else if (NameEntry.Text == UsernameEntry.Text)
            DisplayAlert("Register Failed", "Name and Username must be different.", "OK");
        else if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
            DisplayAlert("Register Failed", "Passwords do not match.", "OK");
        else if (!EmailEntry.Text.Contains("@"))
            DisplayAlert("Register Failed", "Invalid email address.", "OK");
        return false;
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}