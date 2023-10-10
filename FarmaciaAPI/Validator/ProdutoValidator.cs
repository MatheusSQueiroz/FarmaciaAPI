using FarmaciaAPI.Model;
using FluentValidation;

namespace FarmaciaAPI.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(50);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);

            RuleFor(p => p.Preco)
                .NotEmpty();
        }
    }
}
