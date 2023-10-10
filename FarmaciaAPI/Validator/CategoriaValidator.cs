using FarmaciaAPI.Model;
using FluentValidation;

namespace FarmaciaAPI.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Tipo)
                .NotEmpty();
        }
    }
}
