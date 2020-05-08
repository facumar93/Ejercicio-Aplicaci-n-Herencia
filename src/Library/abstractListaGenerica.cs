using System.Collections.Generic;
using System;

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
            var twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("nuevo usuario rideshere",@usuario.ImageName));
            Console.WriteLine("se agrega nuevo usuario a twitter");
        }

            public string ConsumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            public string ConsumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            public string AccessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            public string AccessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
    }

}

