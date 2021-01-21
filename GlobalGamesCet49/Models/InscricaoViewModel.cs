using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Models
{

    public class InscricaoViewModel : Inscricoes
    {
        [Display(Name = "Imagem")]
        public IFormFile ImageFile { get; set; }
    }


}