using System;

namespace TiposDeDatosApp
{
    //Clase Persona es la clase Base para todos los actores de la aplicacion.
    public class Persona
    {
        /*
        //fields
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string email;
        private int telefono;
        private datetime feNacimiento;
        private datetime feIngreso;

        public int Id {
            get { return id; }
            set { id = value; }
            }
    */
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime FeNacimiento { get; set; }
        public DateTime FeIngreso { get; set; }
    }
}