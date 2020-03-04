namespace EntityFrameworkSoftDelete.Models
{
    public class Chamado
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}
