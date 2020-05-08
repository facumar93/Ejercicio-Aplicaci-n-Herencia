public interface IUsuario
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Ci { get; set; }
        double Calificacion { get; set; }
        int CapacidadMaxima { get; set; }
        string ImageName { get; set; }
        
    }