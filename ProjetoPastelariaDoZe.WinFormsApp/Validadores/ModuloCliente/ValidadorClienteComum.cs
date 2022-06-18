using FluentValidation;
using ProjetoPastelariaDoZe.DAO.ModuloCliente;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloCliente
{
    /// <summary>
    /// Validador da Classe Cliente para quando o cliente compra a vista
    /// </summary>
    public class ValidadorClienteComum : AbstractValidator<Cliente>
    {
        /// <summary>
        /// Construtor da classe validador para quando o cliente compra a vista;
        /// </summary>
        public ValidadorClienteComum()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);
        }
    }
}
