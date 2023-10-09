namespace ElectricityTracker;

public partial class RegistroCuenta : ContentPage
{
	public RegistroCuenta()
	{
		InitializeComponent();
	}

    private async void Volver_al_inicio(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}