using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills;

public class GetAllSkillQuery : IRequest<List<SkillViewModel>>
{
    
}