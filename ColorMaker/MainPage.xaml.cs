using CommunityToolkit.Maui.Alerts;

namespace ColorMaker;

public partial class MainPage : ContentPage
{
    public bool IsRandom { get; set; }
    public string HexValue { get; set; }

    public MainPage()
    {
        InitializeComponent();
    }

    private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (IsRandom)
            return;

        var red = sldRed.Value;
        var blue = sldBlue.Value;
        var green = sldGreen.Value;

        Color color = Color.FromRgb(red, blue, green);

        ImplementColor(color);

    }

    private void ImplementColor(Color color)
    {
        Container.BackgroundColor = color;
        btnRandom.BackgroundColor = color;
        HexValue = color.ToHex();
        lblHex.Text = $"HEX Value : {HexValue}";
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {
        IsRandom = true;

        Random rnd = new Random();

        Color color = Color.FromRgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

        sldBlue.Value = color.Blue;
        sldRed.Value = color.Red;
        sldGreen.Value = color.Green;

        ImplementColor(color);

        IsRandom = false;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(HexValue);

        var toast = Toast.Make("Color Copied",CommunityToolkit.Maui.Core.ToastDuration.Short,14);

        toast.Show();
    }
}

