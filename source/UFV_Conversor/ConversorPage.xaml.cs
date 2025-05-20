using Microsoft.Maui.Controls;
using UFV_Conversor.Guided_Practice;
namespace UFV_Conversor;

public partial class ConversorPage : ContentPage
{
    public ConversorPage()
    {
        InitializeComponent();
        AssignButtonEvents();
    }

    private void AssignButtonEvents()
    {
        Button0.Clicked += ButtonNumber_Clicked;
        Button1.Clicked += ButtonNumber_Clicked;
        Button2.Clicked += ButtonNumber_Clicked;
        Button3.Clicked += ButtonNumber_Clicked;
        Button4.Clicked += ButtonNumber_Clicked;
        Button5.Clicked += ButtonNumber_Clicked;
        Button6.Clicked += ButtonNumber_Clicked;
        Button7.Clicked += ButtonNumber_Clicked;
        Button8.Clicked += ButtonNumber_Clicked;
        Button9.Clicked += ButtonNumber_Clicked;

        ButtonA.Clicked += ButtonNumber_Clicked;
        ButtonB.Clicked += ButtonNumber_Clicked;
        ButtonC.Clicked += ButtonNumber_Clicked;
        ButtonD.Clicked += ButtonNumber_Clicked;
        ButtonE.Clicked += ButtonNumber_Clicked;
        ButtonF.Clicked += ButtonNumber_Clicked;

        ButtonAC.Clicked += ButtonAC_Clicked;

        ButtonSign.Clicked += ButtonSign_Clicked;
    }

    private void ButtonNumber_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        InputEntry.Text += button.Text;
    }

    private void ButtonAC_Clicked(object sender, EventArgs e)
    {
        InputEntry.Text = "";
    }

    private void ButtonSign_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "")
        {
            if (InputEntry.Text.StartsWith("-"))
            {
                InputEntry.Text = InputEntry.Text.Substring(1);
            }
            else
            {
                InputEntry.Text = "-" + InputEntry.Text;
            }
        }
    }

    private async void OnOperationsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(UserInfoPage));
    }

    private async void OnLogOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private async void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}