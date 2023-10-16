using prueba_netmaui.Model;
using prueba_netmaui.Repositorio;

namespace prueba_netmaui;

public partial class LoginPage : ContentPage
{
	readonly IUsuarioRepositorio userServer = new UsuarioServicio();
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Login_btn_clicked(object sender, EventArgs e)
	{
		try
		{
			string email = Entry_email.Text;
			if(!email.Contains("@"))
			{
				await DisplayAlert("Error", "Invalid Email", "Ok");
				return;
			}
			string password = Entry_password.Text;
			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
			{
				await Shell.Current.DisplayAlert("Error", "All fields required", "Ok");
				return;
			}

			Usuario user = await userServer.Login(email, password);
			if (user == null)
			{
				await DisplayAlert("Error", "Credentials are incorrect", "Ok");
				return;
			}

			await Navigation.PushAsync(new MainPage());
			await DisplayAlert("Login", "Succesfull logged in", "Ok");
		}catch(Exception ex)
		{
            await DisplayAlert("Login", ex.Message, "Ok");
        }

	}
}