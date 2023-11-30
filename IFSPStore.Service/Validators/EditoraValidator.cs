using FluentValidation;
using IFSPLivraria.Domain.Entities;
using System.Text.RegularExpressions;

namespace IFSPLivraria.Service.Validators
{
    public class EditoraValidator : AbstractValidator<Editora>
    {
        public EditoraValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
        }
    }
}
