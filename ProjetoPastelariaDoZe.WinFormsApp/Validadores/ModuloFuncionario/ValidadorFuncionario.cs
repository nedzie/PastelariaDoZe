using FluentValidation;
using ProjetoPastelariaDoZe.DAO;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloFuncionario
{
    /// <summary>
    /// Classe validadora de informações do tipo funcionário
    /// </summary>
    public class ValidadorFuncionario : AbstractValidator<DAO.Funcionario>
    {
        private const string padrao = "^[0-9]{11}$";
        /// <summary>
        /// Construtor do validador de funcionário
        /// </summary>
        public ValidadorFuncionario()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CPF)
                .NotNull()
                .NotEmpty()
                .Matches(padrao)
                .MinimumLength(11)
                .MaximumLength(11);

            RuleFor(x => x.Matricula)
                .NotNull()
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(11);

            RuleFor(x => x.Senha)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.Grupo)
                .NotNull()
                .NotEmpty();
        }
    }
}
