namespace financeiro.dominio
{
    public class SubCategoria
    {
        public int CategoriaID { get; set; }
        public int SubCategoriaID { get; private set; }
        public string NomeSubCategoria { get; set; }
    }
}