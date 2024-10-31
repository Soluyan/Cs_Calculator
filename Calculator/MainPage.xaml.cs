using CalcCore;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            _calc = new Calc();
            InitializeComponent();
        }

        private readonly Calc _calc;

        private void Button_Pressed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonText = button.Text;
            switch (buttonText)
            {
            case "CE":
                _calc.Input('C');
                break;
            case "±":
                _calc.Input('±');
                break;
            case "%":
                _calc.Input('%');
                break;
            case "√":
                _calc.Input('√');
                break;
            case "1/x":
                _calc.Input('¼');
                break;
            case "x²":
                _calc.Input('²');
                break;
            default:
                if (buttonText.Length == 1)
                {
                    _calc.Input(buttonText[0]);
                }
                break;
            }

            Display.Text = _calc.Display.ToString();
        }
    }
}