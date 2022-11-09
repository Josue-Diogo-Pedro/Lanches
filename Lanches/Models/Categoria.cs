using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Lanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
