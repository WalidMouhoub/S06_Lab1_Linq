namespace LinqEtSeedEF.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public List<Commande> Commandes { get; set; } = new List<Commande>();
        // Initialisation pour éviter NullReferenceException lors de l'itération
        public List<Plat> Plats { get; set; } = new List<Plat>();
    }
}

// Remarque : si vous préférez l'interface ICollection<T> :
// public ICollection<Plat> Plats { get; set; } = new List<Plat>();
// Vous pouvez aussi rendre la propriété virtuelle pour activer le lazy loading si configuré.
