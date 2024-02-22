using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.FinishProject
{

    public class FinishProjectCommandHadler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public FinishProjectCommandHadler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects?.SingleOrDefault(p => p.Id == request.Id);
            project.Finish();
            await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
