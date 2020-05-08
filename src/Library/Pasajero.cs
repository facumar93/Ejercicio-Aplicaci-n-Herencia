namespace PII_Herencia
{
    public class Pasajero : Usuario
    {
        public Pasajero(string name, string lastname, string ci) : base(name, lastname, ci)
        { }

        //se agrega metodo para calificar a conductor
        public void Calificar(Conductor conductor,int calificacion)
        {
            if (conductor.Calificacion == 0)
            {
                conductor.Calificacion = conductor.Calificacion + calificacion;
            }
            else
            {
                conductor.Calificacion = (conductor.Calificacion + calificacion)/2;
            }
            
        }

    }
}