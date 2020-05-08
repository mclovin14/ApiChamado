using ApiChamado.Domain.Model;
using FluentValidation;

namespace ApiChamado.Domain.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Nome).MaximumLength(100).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 100.");
            RuleFor(x => x.Ra).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Ra).MaximumLength(10).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 10.");
        }
    }
}
