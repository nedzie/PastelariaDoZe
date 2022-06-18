using FluentValidation;
using ProjetoPastelariaDoZe.DAO.ModuloCliente;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloCliente
{
    /// <summary>
    /// Validador da classe Cliente para quando o cliente compra fiado e usa CPF
    /// </summary>
    public class ValidadorClienteFiadoCPF : AbstractValidator<Cliente>
    {
        private const string padraoCPF = "^[0-9]{11}$";
        /// <summary>
        /// Construtor da classe Cliente para quando o cliente compra fiado e usa CPF
        /// </summary>
        public ValidadorClienteFiadoCPF()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CPF)
                .NotNull()
                .NotEmpty()
                .Matches(padraoCPF)
                .MinimumLength(11)
                .MaximumLength(11);

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(11);

            RuleFor(x => x.Senha)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
