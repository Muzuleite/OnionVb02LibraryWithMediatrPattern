using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;

public class CreateTagCommandValidator : AbstractValidator<CreateTagCommand>
{
    public CreateTagCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Etiket adı boş olamaz.")
            .MaximumLength(50).WithMessage("Etiket adı en fazla 50 karakter olabilir.");
    }
}

