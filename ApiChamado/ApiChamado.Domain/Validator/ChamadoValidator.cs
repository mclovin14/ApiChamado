using ApiChamado.Domain.Model;
using FluentValidation;

namespace ApiChamado.Domain.Validator
{
    public class ChamadoValidator : AbstractValidator<Chamado>
    {
        public ChamadoValidator()
        {
            RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Nome)
              .MaximumLength(100).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 100.");
            RuleFor(x => x.Email)
           .NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Email)
              .MaximumLength(100).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 100.");
        }
    }
}
