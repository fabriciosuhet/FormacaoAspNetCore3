using Dapper;
using DevFreela.Application.ViewModels;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Queries.GetAllSkills;

public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillQuery, List<SkillViewModel>>
{
    
    private readonly string _connectionString;
    public GetAllSkillsQueryHandler(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DevFreelaCs");
    }
    public async Task<List<SkillViewModel>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
    {
        using ( var sqlConnection = new SqlConnection(_connectionString))
        {
            sqlConnection.Open();

            var script = "SELECT Id, Description FROM Skills";

            var skills = await sqlConnection.QueryAsync<SkillViewModel>(script);
            return skills.ToList();
            
            // Com EF Core
            //var skills = _dbContext.Skills;
            //var skillsViewModel = skills
            //    .Select(s => new SkillViewModel(s.Id, s.Description))
            //    .ToList();

            //return skillsViewModel;
        }
    }
}