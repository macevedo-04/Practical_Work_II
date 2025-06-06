namespace UFV_Conversor;

public partial class UserInfoPage : ContentPage, IQueryAttributable
{
    private string currentUsername;
    public UserInfoPage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("username"))
            this.currentUsername = query["username"].ToString();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        string filePath = "files/users.csv";

        if (File.Exists(filePath))
        {
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] fields = line.Split(';');
                if (fields[1] == currentUsername)
                {
                    NameLabel.Text = "Name: " + fields[0];
                    UsernameLabel.Text = "Username: " + fields[1];
                    EmailLabel.Text = "Email: " + fields[2];
                    PasswordLabel.Text = "Password: " + fields[3];
                    NumOperationsLabel.Text = "Number of operations: " + fields[4];
                }
            }
        }
    }

    private async void OnLogOutClicked(object sender, EventArgs e)
    {
        this.currentUsername = "";
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}