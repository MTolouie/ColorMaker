namespace ColorMaker;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
    {
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
        lblHex.Text = $"HEX Value : {color.ToHex()}";
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }
}

