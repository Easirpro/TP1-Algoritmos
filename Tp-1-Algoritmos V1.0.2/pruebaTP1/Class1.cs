using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pruebaTP1
{
    public class DBAccess
    {
        private OleDbConnection conexion;
        public OleDbConnection GetConnection()
        {
            string cadena = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\\tp_algoritmo.accdb";
            conexion = new OleDbConnection(cadena);

            return conexion;
        }
    }
    public class User
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


