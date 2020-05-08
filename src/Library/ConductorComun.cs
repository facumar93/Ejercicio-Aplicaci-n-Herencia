namespace PII_Herencia
{
    public class ConductorComun : Conductor
    {
        public ConductorComun(string name, string lastname, string ci) : base(name, lastname, ci)
        { 
            this.CapacidadMaxima = 1;
        }
    }
}