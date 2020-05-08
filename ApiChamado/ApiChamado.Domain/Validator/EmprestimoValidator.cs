using ApiChamado.Domain.Model;
using FluentValidation;

namespace ApiChamado.Domain.Validator
{
    public class EmprestimoValidator : AbstractValidator<Emprestimo>
    {
        public EmprestimoValidator()
        {
            RuleFor(x => x.ClienteId).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.LivroId).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.DataEntrega).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            RuleFor(x => x.DataAluguel).NotEmpty().WithMessage("O preenchimento do campo é obrigatório.");
            
        }
    }
}
