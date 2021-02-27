using FluentValidation;

namespace MyDocs.Application.Groups.Commands.CreateGroup
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(v => v.Name)
                .NotEmpty();
        }
    }
}
