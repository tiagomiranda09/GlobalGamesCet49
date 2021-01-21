using System;
using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Dados.Entidades
{
    public class Inscricoes
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Apelido")]
        public string Apelido { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }


        [Display(Name = "Image")]
        public string ImageFile { get; set; }



    }
}
