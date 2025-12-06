using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.AuthorCommands;

public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
{
    public CreateAuthorCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Yazar adı boş olamaz.")
            .MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakter olabilir.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Yazar soyadı boş olamaz.")
            .MaximumLength(50).WithMessage("Yazar soyadı en fazla 50 karakter olabilir.");
    }


}


