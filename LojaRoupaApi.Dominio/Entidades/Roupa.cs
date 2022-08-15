namespace LojaRoupaApi.Dominio.Entidades
{
    public class Roupa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Tipo Tipo { get; set; }
        public ICollection<RoupaVariacao> RoupasVariacao { get; set; }
    }
}
