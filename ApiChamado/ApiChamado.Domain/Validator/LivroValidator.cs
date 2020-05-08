using ApiChamado.Domain.Model;
using FluentValidation;

namespace ApiChamado.Domain.Validator
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Nome).MaximumLength(100).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 100.");
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.Descricao).MaximumLength(500).WithMessage("O numero de caracteres máximo foi ultrapassado. Limite: 500.");
            RuleFor(x => x.Status).NotNull().WithMessage("O preenchimento do campo é obrigatório.");
        }
    }

}
