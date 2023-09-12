using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class DeleteCandidateCommandHandler : CommandHandlerBase<DeleteCandidateCommand, DeleteCandidateResponse>
    {
        public DeleteCandidateCommandHandler(ICommandCandidateAppService commandCandidateAppService) 
            : base(commandCandidateAppService)
        {
        }

        public override Task<DeleteCandidateResponse> Handle(DeleteCandidateCommand command, CancellationToken cancellationToken) => 
            CommandCandidateAppService.Delete(command);
    }
}
