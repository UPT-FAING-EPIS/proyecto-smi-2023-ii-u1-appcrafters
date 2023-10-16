using prueba_netmaui.Model;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace prueba_netmaui.Repositorio
{
    public class UsuarioServicio : IUsuarioRepositorio
    {
        public async Task<Usuario> Login(string correo, string contraseña)
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:7140/api/Usuarios/" + correo + "/" + contraseña;

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Usuario user = JsonConvert.DeserializeObject<Usuario>(content);
                        return user;
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error al realizar la solicitud HTTP: {e.Message}");
                }

                return null;
            }
        }
    }
}
