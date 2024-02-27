using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators;

public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
{
    public UpdateProjectCommandValidator()
    {
        RuleFor(p => p.Description)
            .MaximumLength(255)
            .WithMessage("A descrição deve ter apenas 255 caracteres.");

        RuleFor(p => p.Title)
            .MaximumLength(30)
            .WithMessage("O título deve ter apenas 30 caracteres");
    }
}