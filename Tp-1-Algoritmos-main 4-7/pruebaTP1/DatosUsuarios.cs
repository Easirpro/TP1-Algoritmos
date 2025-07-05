using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTP1
{
    public static class DatosUsuario
    {
        public static string Usuario { get; set; } = "Jose123"; 
        public static string Nombre { get; set; } = "Jose";
        public static string Apellido { get; set; } = "Pérez";
        public static string Dni { get; set; } = "12345678";
        public static string Telefono { get; set; } = "123456789";
        public static string Email { get; set; } = "juan@email.com";
        public static string Password { get; set; } = "12345";
        public static string Rol { get; set; } = "Usuario";
    }

    public static class DatosAdmin
    {
        public static string Usuario { get; set; } = "Javi123";
        public static string Nombre { get; set; } = "Javi";
        public static string Apellido { get; set; } = "De Leon";
        public static string Dni { get; set; } = "12345678";
        public static string Telefono { get; set; } = "123456789";
        public static string Email { get; set; } = "javi@email.com";
        public static string Password { get; set; } = "12345";
        public static string Rol { get; set; } = "Administrador";
    }
}
