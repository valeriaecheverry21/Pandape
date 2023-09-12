using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class UpdateCandidateCommandHandler : CommandHandlerBase<UpdateCandidateCommand, UpdateCandidateResponse>
    {
        public UpdateCandidateCommandHandler(ICommandCandidateAppService commandCandidateAppService) 
            : base(commandCandidateAppService)
        {
        }

        public override Task<UpdateCandidateResponse> Handle(UpdateCandidateCommand command, CancellationToken cancellationToken) =>
            CommandCandidateAppService.Update(command);
    }
}
