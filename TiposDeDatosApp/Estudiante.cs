namespace TiposDeDatosApp
{
    //La clase estudiante hereda de la clase Persona.
    public class Estudiante : Persona
    {
        //no necesito agregar ninguna propiedad porque 
        //la clase base tiene todos los campos que requiere.
       
        public void GetInfoEstudiante()
        {
            Console.WriteLine(this.Nombre + " " + this.Apellido);
        }
    }
}