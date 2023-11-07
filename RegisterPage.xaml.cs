using EmailAuth.ViewModels;

namespace EmailAuth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(Navigation);
            ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "/Resources/Images/retroceder.jpg", // Aquí debes especificar la ruta de la imagen para el botón de retroceso
                Text = "Retroceder",
                Order = ToolbarItemOrder.Primary,
                Priority = 0
            });

            // Manejar el evento de hacer clic en el botón de retroceso
            ToolbarItems[0].Clicked += (sender, e) =>
            {
                Navigation.PopAsync(); // Esto retrocederá a la página anterior
            };
        }
    }
}