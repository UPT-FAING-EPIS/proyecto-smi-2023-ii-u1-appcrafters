namespace ElectricityTracker;

public partial class Configuracion_barra : ContentPage
{
	public Configuracion_barra()
	{
		InitializeComponent();
	}

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}