using System.ComponentModel.DataAnnotations;

namespace ApiTibiaColecao.Dto
{
    public class CreateItemDto
    {

        [Required(ErrorMessage = "É obrigatório dar um nome ao item")]
        [StringLength(50, ErrorMessage = "O nome do item deve conter até 50 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "É obrigatório indicar a qual categoria o item pertence")]
        public string categoria { get; set; }

        [Required(ErrorMessage = "É obrigatório fornecer uma URL com a imagem do item")]
        public string imagem { get; set; }

        [Required(ErrorMessage = "É obrigatório indicar se o item ja faz parte da coleção")]
        public Boolean possui { get; set; }
    }
}

