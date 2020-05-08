using System.Collections.Generic;

namespace PII_Herencia

{
    public abstract class ListaGenerica<T> where T : IUsuario
    {
        protected List<T> usuarios;

        protected ListaGenerica()
        {
            this.usuarios = new List<T>();
        }

        public void addUsuario(T usuario)
        {
            this.usuarios.Add(usuario);
        }
    }

}

