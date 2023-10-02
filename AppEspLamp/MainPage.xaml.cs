namespace AppEspLamp;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnRegistroLabelTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//RegistroCuentaPage");
    }
	
}

