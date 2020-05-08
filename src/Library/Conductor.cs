using System;

namespace PII_Herencia
{
public class Conductor : Usuario 
    {
        public Conductor(string name, string lastname, string ci) : base(name, lastname, ci)
        { 
            this.Vehiculo = Vehiculo;
            this.Bio = Bio;
        }

        //se agrega metodo para calificar pasajero
        public void Calificar(Pasajero pasajero,int calificacion)
        {
            if (pasajero.Calificacion == 0)
                pasajero.Calificacion = pasajero.Calificacion + calificacion;
            else
                pasajero.Calificacion = (pasajero.Calificacion + calificacion)/2;
        }

        //se agrega metodo para llevar a pasajero
        public void LlevarPasajero(Pasajero pasajero)
        {
            Console.WriteLine ("Llevo a " + pasajero.Name);
        }

        public string Vehiculo { get; set; }
        public string Bio { get; set; }

    }
}