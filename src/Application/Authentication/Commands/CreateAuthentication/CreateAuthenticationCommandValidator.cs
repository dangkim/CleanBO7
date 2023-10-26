using FluentValidation;

namespace CleanBO7.Application.Products.Commands.CreateProduct;

public class CreateAuthenticationCommandValidator : AbstractValidator<CreateAuthenticationCommand>
{
    public CreateAuthenticationCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
