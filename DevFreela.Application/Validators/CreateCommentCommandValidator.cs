using DevFreela.Application.Commands.CreateComment;
using FluentValidation;

namespace DevFreela.Application.Validators;

public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
{
    public CreateCommentCommandValidator()
    {
        RuleFor(c => c.Content)
            .MaximumLength(255)
            .WithMessage("O comentário deve ter apenas 255 caracteres");
    }
}