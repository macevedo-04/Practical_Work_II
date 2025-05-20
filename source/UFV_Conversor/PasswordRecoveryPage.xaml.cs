namespace UFV_Conversor;

public partial class PasswordRecoveryPage : ContentPage
{
    public PasswordRecoveryPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private async void OnRecoverClicked(object sender, EventArgs e)
    {
        string filePath = "files/users.csv";

        if (File.Exists(filePath)) {
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 0; i < lines.Length; i++) {
                string[] fields = lines[i].Split(';');
                if (fields[1] == UsernameEntry.Text && NewPasswordEntry.Text == ConfirmPasswordEntry.Text) {
                    fields[3] = NewPasswordEntry.Text;
                    lines[i] = string.Join(";", fields);
                    found = true;
                }
            }

            if (found) {
                File.WriteAllLines(filePath, lines);
                await DisplayAlert("Success", "Password changed successfully.", "OK");
            }
            else
                await DisplayAlert("Error", "Username not found or passwords do not match.", "OK");
        }
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}