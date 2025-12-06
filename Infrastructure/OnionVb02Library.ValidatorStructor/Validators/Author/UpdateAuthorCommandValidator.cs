using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;

public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
{
    public UpdateAuthorCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Author Id geçerli değil.");

        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Yazar adı boş olamaz.")
            .MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakter olabilir.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Yazar soyadı boş olamaz.")
            .MaximumLength(50).WithMessage("Yazar soyadı en fazla 50 karakter olabilir.");
    }
}


