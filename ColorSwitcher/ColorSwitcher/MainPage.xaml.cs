using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcher
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = redSlider.Value;
            var green = greenSlider.Value;
            var blue = blueSlider.Value;

            Color bgColor = new Color(red, green, blue);

            boxColor.BackgroundColor = bgColor;

            lblDisplay.Text = ColorToHex(bgColor);
        }

        private string ColorToHex(Color bgColor)
        {
            int red = (int)(bgColor.R * 255);
            int green = (int)(bgColor.G * 255);
            int blue = (int)(bgColor.B * 255);
            int alpha = (int)(bgColor.A * 255);

            return "Valor Hexadecimal: " + $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";


        }
    }
}
