using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.Delete
{
    public class DeleteProjectCommandHadler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public DeleteProjectCommandHadler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetProjectByIdAsync(request.Id);
            project?.Cancel();
            await _projectRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
