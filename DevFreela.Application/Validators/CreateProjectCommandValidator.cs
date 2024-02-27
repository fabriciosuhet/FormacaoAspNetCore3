using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators;

public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
{
    public CreateProjectCommandValidator()
    {
        RuleFor(p => p.Description)
            .MaximumLength(255)
            .WithMessage("Tamanha máximo de descrição é de 255 caracteres.");

        RuleFor(p => p.Title)
            .MaximumLength(30)
            .WithMessage("Tamanho máximo de título é de 30 caracteres");
    }
}