using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class InsertCandidateCommandHandler : CommandHandlerBase<InsertCandidateCommand, InsertCandidateResponse>
    {
        public InsertCandidateCommandHandler(ICommandCandidateAppService commandCandidateAppService) 
            : base(commandCandidateAppService)
        {
        }

        public override Task<InsertCandidateResponse> Handle(InsertCandidateCommand command, CancellationToken cancellationToken) =>
            CommandCandidateAppService.Insert(command);
    }
}
