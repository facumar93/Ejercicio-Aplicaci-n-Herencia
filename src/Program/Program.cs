using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario pasajero1 = new Pasajero("carlos","gomez","1.111.111-1");
            Usuario pasajero2 = new Pasajero("vero", "perez", "2.222.222-2");
            Usuario pasajero3 = new Pasajero("fabi", "duran", "3.333.333-3");
            Usuario conductorC1 = new ConductorComun("pedro", "perez", "4.444.444-4");
            Usuario conductorP1 = new ConductorPool("mario", "perez", "5.555.555-5");

            conductorP1.CapacidadMaxima = 3;

            ListaConductores conductores = new ListaConductores();
            //conductores.addUsuario(conductorC1);

            ListaPasajeros pasajeros = new ListaPasajeros();
            //pasajeros.addUsuario(pasajero1);




            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
