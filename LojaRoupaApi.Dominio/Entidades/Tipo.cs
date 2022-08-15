namespace LojaRoupaApi.Dominio.Entidades
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Roupa> Roupas { get; set; }
    }
}
