using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartProjectCommandHadler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public StartProjectCommandHadler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetProjectByIdAsync(request.Id);

            project.Start();
            await _projectRepository.StartAsync(project);
            
            return Unit.Value;
        }
    }
}
