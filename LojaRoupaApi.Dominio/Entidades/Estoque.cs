namespace LojaRoupaApi.Dominio.Entidades
{
    public class Estoque
    {
        public int Id { get; set; }
        public int IdRoupaVariacao {get; set;}
        public RoupaVariacao RoupaVariacao { get; set;}
        public int Quantidade { get; set;}
    }
}
