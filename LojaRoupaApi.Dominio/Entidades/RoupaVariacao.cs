namespace LojaRoupaApi.Dominio.Entidades
{
    public class RoupaVariacao
    {
        public int Id { get; set; }
        public Cor Cor { get; set; }
        public string Tamanho { get; set; }
        public Roupa Roupa { get; set; }
        public Estoque Estoque { get; set; }
        public ICollection<Venda> Vendas { get; set; }
    }
}
