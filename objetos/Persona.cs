namespace Objetos
{
    public abstract class Persona
    {
        public Persona(int ci, string nombre, string segundo_nombre, string apellido, string segundo_apellido, string email, int telefono)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.segundo_nombre = segundo_nombre;
            this.apellido = apellido;
            this.segundo_apellido = segundo_apellido;
            this.email = email;
            this.telefono = telefono;
        }

        public int ci { get; set; }
        public string nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
    }
}