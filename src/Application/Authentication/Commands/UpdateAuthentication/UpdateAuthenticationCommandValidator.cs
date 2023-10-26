using FluentValidation;

namespace CleanBO7.Application.Authentication.Commands.UpdateAuthentication;

public class UpdateAuthenticationCommandValidator : AbstractValidator<UpdateAuthenticationCommand>
{
    public UpdateAuthenticationCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
