using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTP1
{
    //Código de verificación recupero es: 1234
    public static class DatosUsuario
    {
        public static string Nombre { get; set; } = "Jose";
        public static string Apellido { get; set; } = "Pérez";
        public static string Dni { get; set; } = "12345678";
        public static string Telefono { get; set; } = "12345678";
        public static string Email { get; set; } = "jose@email.com";
        public static string Password { get; set; } = "12345";
        public static string Rol { get; set; } = "Usuario";
    }

    public static class DatosAdmin
    {
        public static string Nombre { get; set; } = "Javier";
        public static string Apellido { get; set; } = "De Leon";
        public static string Dni { get; set; } = "12345678";
        public static string Telefono { get; set; } = "12345678";
        public static string Email { get; set; } = "javi@email.com";
        public static string Password { get; set; } = "12345";
        public static string Rol { get; set; } = "Administrador";
    }

    public static class Usuarios
    {
        public static List<Usuario> Lista = new List<Usuario>();
    }
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}