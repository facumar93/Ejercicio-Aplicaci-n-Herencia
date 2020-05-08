
namespace PII_Herencia
{
    public abstract class Usuario : IUsuario
    {
        protected Usuario(string name, string lastname, string ci)
        {
            this.Name = name;
            this.LastName  = lastname;
            this.Ci = ci;
            this.Calificacion = 0;
            this.ImageName = ImageName;
        }


        public double Calificacion { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Ci { get; set; }
        public int CapacidadMaxima { get; set; }
        public string ImageName { get; set; }
    }
}