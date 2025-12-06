using FluentValidation;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("Kategori adı boş olamaz.")
            .MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olabilir.");

        RuleFor(x => x.Description)
            .MaximumLength(200).WithMessage("Açıklama en fazla 200 karakter olabilir.");
    }
}
