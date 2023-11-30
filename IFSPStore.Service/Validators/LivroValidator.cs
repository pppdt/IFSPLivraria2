using FluentValidation;
using IFSPLivraria.Domain.Entities;

namespace IFSPLivraria.Service.Validators
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

        }
    }
}
