using System.ComponentModel.DataAnnotations;

namespace ApiTibiaColecao.Dto
{
    public class GetItemDto
    {
        public string nome { get; set; }

        public string categoria { get; set; }

        public string imagem { get; set; }

        public Boolean possui { get; set; }

        public DateTime HoraConsulta { get; set; } = DateTime.Now;
    }
}

