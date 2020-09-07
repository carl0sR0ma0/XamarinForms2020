
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }

        private void ActionValorMudou(object sender, ValueChangedEventArgs args)
        {
            SliderResult.Text = args.NewValue.ToString();
        }
        private void ActionValorMudouStepper(object sender, ValueChangedEventArgs args)
        {
            StepperResult.Text = args.NewValue.ToString();
        }
    }
}