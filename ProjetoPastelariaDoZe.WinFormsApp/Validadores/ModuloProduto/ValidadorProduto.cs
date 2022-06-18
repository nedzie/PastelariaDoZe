using FluentValidation;
using ProjetoPastelariaDoZe.DAO.ModuloProduto;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloProduto
{
    /// <summary>
    /// Classe validadora das informações dos produtos
    /// </summary>
    public class ValidadorProduto : AbstractValidator<Produto>
    {
        /// <summary>
        /// Construtor da classe validadora de produtos
        /// </summary>
        public ValidadorProduto()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.ValorUn)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Foto)
                .NotNull()
                .NotEmpty();
        }
    }
}
