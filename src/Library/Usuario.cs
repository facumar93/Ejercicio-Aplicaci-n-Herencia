using System;

namespace PII_Herencia
{
    public abstract class Usuario : IUsuario
    {
        protected Usuario(string name, string lastname, string ci)
        {
            this.Name = name;
            this.LastName  = lastname;
            this.Ci = ci;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Ci { get; set; }

    }
    public abstract class Shape
    {
        public abstract int Area();
        public abstract int Perimeter();

    }
}