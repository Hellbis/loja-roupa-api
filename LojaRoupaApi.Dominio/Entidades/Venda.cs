namespace LojaRoupaApi.Dominio.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdRoupaVariacao { get; set; }
        public RoupaVariacao RoupaVariacao { get; set; }
        public double Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
