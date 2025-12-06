using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.BookTagCommands;

public class CreateBookTagCommandValidator : AbstractValidator<CreateBookTagCommand>
{
    public CreateBookTagCommandValidator()
    {
        RuleFor(x => x.BookId)
            .GreaterThan(0).WithMessage("Geçerli bir kitap Id giriniz.");

        RuleFor(x => x.TagId)
            .GreaterThan(0).WithMessage("Geçerli bir tag Id giriniz.");
    }
}
