using System.ComponentModel.DataAnnotations;


namespace GlobalGames.Dados.Entidades
{
    public class Contactos
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }

        [Display(Name = "Mensagem")]
        public string Mensagem { get; set; }
    }
}
