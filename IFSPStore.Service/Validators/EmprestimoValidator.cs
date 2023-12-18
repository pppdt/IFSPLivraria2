using FluentValidation;
using IFSPLivraria.Domain.Entities;


namespace IFSPLivraria.Service.Validators
{
    public class EmprestimoValidator : AbstractValidator<Emprestimo>
    {
        public EmprestimoValidator()
        {
            RuleFor(c => c.Cliente)
                .NotEmpty().WithMessage("Por favor informe o cliente.")
                .NotNull().WithMessage("Por favor informe o cliente.");
           
        }


    }
}
   