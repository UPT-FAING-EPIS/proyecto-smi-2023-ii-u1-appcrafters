namespace ElectricityTracker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnRegistroLabelTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RegistroCuenta");
        }

        private async void OnIniciarSesionClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MenuPrincipal");
        }

    }
}