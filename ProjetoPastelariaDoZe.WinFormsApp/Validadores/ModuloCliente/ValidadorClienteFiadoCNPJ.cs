using FluentValidation;
using ProjetoPastelariaDoZe.DAO.ModuloCliente;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloCliente
{
    /// <summary>
    /// Validador de cliente para quando não compra fiado e usa CNPJ
    /// </summary>
    public class ValidadorClienteFiadoCNPJ : AbstractValidator<Cliente>
    {
        private const string padraoCNPJ = "^[0-9]{14}";
        /// <summary>
        /// Construtor da classe ValidadorFuncionario para quando o cliente não compra fiado e usa CNPJ
        /// </summary>
        public ValidadorClienteFiadoCNPJ()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CNPJ)
                .NotNull()
                .NotEmpty()
                .Matches(padraoCNPJ)
                .MinimumLength(14)
                .MaximumLength(14);


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
