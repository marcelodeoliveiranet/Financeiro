using System.ComponentModel.DataAnnotations;

namespace financeiro.dominio
{
    public class Categoria
    {
        public int CategoriaID { get; private set; }
        public string NomeCategoria { get; set; }
        public ICollection<SubCategoria> SubCategorias { get; set; }
    }
}