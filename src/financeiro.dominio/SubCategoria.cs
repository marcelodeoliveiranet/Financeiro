namespace financeiro.dominio
{
    public class SubCategoria
    {
        public int Id { get; private set; }
        public int IdCategoria { get; private set; }
        public string NomeSubCategoria { get; set; }
    }
}