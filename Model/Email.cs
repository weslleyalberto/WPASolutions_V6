using System.ComponentModel.DataAnnotations;

namespace WPASolutions_V6.Model
{
    public class Email
    {
        [Required(ErrorMessage = "O campo {0} deve ser preenchido!")]
        [MinLength(2,ErrorMessage ="O Campo {0} deve conter no mínino {1} caracteres!")]
        [MaxLength(20,ErrorMessage ="O campo {0} deve conter no máximo {1} caracteres!")]
        public string Nome { get; private set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido!")]
        [MinLength(4, ErrorMessage = "O Campo {0} deve conter no mínino {1} caracteres!")]
        [MaxLength(70, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres!")]
        public string Sobrenome { get; private set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "O campo {0} deve ser preenchido corretamente!")]
        public string Emails { get; private set; }
        public IEnumerable<string> Assunto { get; private set; } = new List<string>() { "Arte gráfica", "Publicidade e Markenting", "Sites", "E-Commerce", "Aplicativos para Smartphones" };
        [Required(ErrorMessage = "O campo {0} deve ser preenchido!")]
        [MinLength(5, ErrorMessage = "O Campo {0} deve conter no mínino {1} caracteres!")]
        [MaxLength(500, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres!")]
        public string Mensagem { get; private set; }
        public Email(string nome, string sobrenome, string emails, IEnumerable<string> assunto, string mensagem)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Emails = emails;
            Assunto = assunto;
            Mensagem = mensagem;
        }
    }
}
