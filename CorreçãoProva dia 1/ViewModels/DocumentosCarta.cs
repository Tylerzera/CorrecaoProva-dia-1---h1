using System.ComponentModel.DataAnnotations;

namespace CorreçãoProva_dia_1.Controllers
{
    public class DocumentosCarta
    {
        [MinLength(3, ErrorMessage = "Minimo 3 Caracteres.")]
        [MaxLength(255, ErrorMessage = "Maximo 255 Caracteres.")]
        [Required(ErrorMessage = "Nome Obrigatorio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Rua Obrigatoria.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Numero Civico Obrigatorio.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Bairro Obrigatorio.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade Obrigatoria.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado Obrigatorio.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Idade Obrigatoria.")]
        [Range(0, 15)]
        public int Idade { get; set; }

        [MinLength(1, ErrorMessage = "Minimo 1 Caracteres.")]
        [MaxLength(500, ErrorMessage = "Maximo 500 Caracteres.")]
        [Required(ErrorMessage = "Texto Obrigatorio.")]
        public string Texto { get; set; }

    }
}
