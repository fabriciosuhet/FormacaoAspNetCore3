using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.FinishProject
{

    public class FinishProjectCommandHadler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public FinishProjectCommandHadler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetProjectByIdAsync(request.Id);
            project.Finish();
            await _projectRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
