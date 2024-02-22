using Azure.Core;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Commands.Delete
{
    public class DeleteProjectCommandHadler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public DeleteProjectCommandHadler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects?.SingleOrDefault(p => p.Id == request.Id);
            project?.Cancel();
            await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
