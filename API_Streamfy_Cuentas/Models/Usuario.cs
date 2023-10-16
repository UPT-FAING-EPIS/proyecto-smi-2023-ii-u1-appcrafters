using System;
using System.Collections.Generic;

namespace APICuentas.Models;

public partial class Usuario
{
    public string Correo { get; set; } = null!;

    public string? Contraseña { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Telefono { get; set; }
}
