using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.TagCommands;

public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommand>
{
    public UpdateTagCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Tag Id geçerli değil.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Etiket adı boş olamaz.")
            .MaximumLength(50).WithMessage("Etiket adı en fazla 50 karakter olabilir.");
    }
}

