namespace AppEspLamp;

public partial class RegistroCuentaPage : ContentPage
{
	
	public RegistroCuentaPage()
	{
		InitializeComponent();
	}

	private async void Volver_al_inicio(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
	
}
