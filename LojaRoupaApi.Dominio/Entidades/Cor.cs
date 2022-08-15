namespace LojaRoupaApi.Dominio.Entidades
{
    public class Cor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<RoupaVariacao> RoupasVariacoes { get; set; }
    }
}
