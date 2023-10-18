using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CorreçãoProva_dia_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly string _CartaCaminhoArquivo;

        public CartaController()
        {
            _CartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJson", "Cartinha.json");
        }
        private List<DocumentosCarta> LerCartaDoArquivo()
        {
            if (!System.IO.File.Exists(_CartaCaminhoArquivo))
            {
                return new List<DocumentosCarta>();
            }

            string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        }
        private void EscreverCartaNoArquivo(List<DocumentosCarta> campos)
        {
            string json = JsonConvert.SerializeObject(campos);
            System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        }

        [HttpPost]
        public IActionResult Post(DocumentosCarta documentoCarta)
        {
            var listaCarta = LerCartaDoArquivo();
            listaCarta.Add(documentoCarta);
            EscreverCartaNoArquivo(listaCarta);
            return Ok("Carta cadastrada com sucesso!");

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(LerCartaDoArquivo());
        }
    }
}

