using DevFreela.Core.DTOs;
using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills;

public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillQuery, List<SkillDTO>>
{
    
    private readonly string _connectionString;
    private readonly ISkillRepository _skillRepository;
    public GetAllSkillsQueryHandler(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;

    }
    public async Task<List<SkillDTO>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
    {
        return await _skillRepository.GetAllAsync();
    }
}