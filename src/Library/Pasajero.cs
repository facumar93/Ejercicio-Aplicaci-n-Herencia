using System;

namespace PII_Herencia
{
    public class Pasajero : Usuario
    {
        public Pasajero(string name, string lastname, string ci) : base(name, lastname, ci)
        { }
    }
}