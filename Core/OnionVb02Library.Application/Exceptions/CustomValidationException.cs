using FluentValidation.Results;

namespace OnionVb02Library.Application.Exceptions
{
    public class CustomValidationException : Exception
    {
        public List<string> Errors { get; }

        public CustomValidationException(IEnumerable<ValidationFailure> failures)
            : base("Validasyon hatası.")
        {
            Errors = failures.Select(f => f.ErrorMessage).ToList();
        }
    }
}
