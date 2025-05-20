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

        ButtonDecToBin.Clicked += ButtonDecToBin_Clicked;
        ButtonDecToTwoComp.Clicked += ButtonDecToTwoComp_Clicked;
        ButtonDecToOct.Clicked += ButtonDecToOct_Clicked;
        ButtonDecToHex.Clicked += ButtonDecToHex_Clicked;
        ButtonBinToDec.Clicked += ButtonBinToDec_Clicked;
        ButtonTwoCompToDec.Clicked += ButtonTwoCompToDec_Clicked;
        ButtonOctToDec.Clicked += ButtonOctToDec_Clicked;
        ButtonHexToDec.Clicked += ButtonHexToDec_Clicked;
    }

    private void ButtonNumber_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        InputEntry.Text += button.Text;
    }

    private void ButtonAC_Clicked(object sender, EventArgs e)
    {
        InputEntry.Text = "";
        OutputLabel.Text = "";
    }

    private void ButtonSign_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            if (InputEntry.Text.StartsWith("-")) {
                InputEntry.Text = InputEntry.Text.Substring(1);
            }
            else {
                InputEntry.Text = "-" + InputEntry.Text;
            }
        }
    }

    private void ButtonDecToBin_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                DecimalToBinary converter = new DecimalToBinary("Binary", "Decimal to Binary");
                string binaryNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = binaryNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonDecToTwoComp_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                DecimalToTwosComplement converter = new DecimalToTwosComplement("Two's Complement", "Decimal to Two's Complement");
                string twoCompNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = twoCompNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonDecToOct_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                DecimalToOctal converter = new DecimalToOctal("Octal", "Decimal to Octal");
                string octalNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = octalNumber;
                
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonTwoCompToDec_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                TwosComplementToDecimal converter = new TwosComplementToDecimal("Decimal", "Two's Complement to Decimal");
                string decimalNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = decimalNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonDecToHex_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                DecimalToHexadecimal converter = new DecimalToHexadecimal("Hexadecimal", "Decimal to Hexadecimal");
                string hexNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = hexNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonBinToDec_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                BinaryToDecimal converter = new BinaryToDecimal("Decimal", "Binary to Decimal");
                string decimalNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = decimalNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonOctToDec_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                OctalToDecimal converter = new OctalToDecimal("Decimal", "Octal to Decimal");
                string decimalNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = decimalNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
            }
        }
    }

    private void ButtonHexToDec_Clicked(object sender, EventArgs e)
    {
        if (InputEntry.Text != "") {
            try {
                HexadecimalToDecimal converter = new HexadecimalToDecimal("Decimal", "Hexadecimal to Decimal");
                string decimalNumber = converter.Change(InputEntry.Text);
                OutputLabel.Text = decimalNumber;
            }
            catch (Exception ex) {
                OutputLabel.Text = $"Error: {ex.Message}";
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