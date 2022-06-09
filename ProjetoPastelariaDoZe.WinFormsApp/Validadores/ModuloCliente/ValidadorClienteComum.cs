using FluentValidation;
using ProjetoPastelariaDoZe.DAO;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloCliente
{
    /// <summary>
    /// Validador da Classe Cliente para quando o cliente compra a vista
    /// </summary>
    public class ValidadorClienteComum : AbstractValidator<DAO.Cliente>
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
