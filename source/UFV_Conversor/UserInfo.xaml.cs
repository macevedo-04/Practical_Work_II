namespace UFV_Conversor;

public partial class UserInfoPage : ContentPage
{
    public UserInfoPage()
    {
        InitializeComponent();
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}