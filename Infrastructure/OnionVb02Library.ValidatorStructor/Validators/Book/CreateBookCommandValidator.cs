using FluentValidation;
using OnionVb02Library.Application.Mediatrs.Commands.BookCommands;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Kitap adı boş olamaz.")
            .MaximumLength(100).WithMessage("Kitap adı en fazla 100 karakter olabilir.");

        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Fiyat boş geçilemez.")
            .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");

        RuleFor(x => x.AuthorId)
            .GreaterThan(0).WithMessage("Geçerli bir yazar Id giriniz.");

        RuleFor(x => x.CategoryId)
            .GreaterThan(0).WithMessage("Geçerli bir kategori Id giriniz.");
    }
}



