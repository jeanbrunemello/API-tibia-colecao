using System.ComponentModel.DataAnnotations;

namespace ApiTibiaColecao.Models
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório dar um nome ao item")]
        public string nome { get; set; }

        [Required(ErrorMessage = "É obrigatório indicar a qual categoria o item pertence")]
        public string categoria { get; set; }

        [Required(ErrorMessage = "É obrigatório fornecer uma URL com a imagem do item")]
        public string imagem { get; set; }

        [Required(ErrorMessage = "É obrigatório indicar se o item ja faz parte da coleção")]
        public Boolean possui { get; set; }
    }
    
}
