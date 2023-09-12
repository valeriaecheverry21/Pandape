using MediatR;
using Pandape.Application.AppServices;
using System.Threading.Tasks;
using System.Threading;

namespace Pandape.Application.CQRS.Handlers
{
    public abstract class CommandHandlerBase<TRequest, TResponse> 
        : IRequestHandler<TRequest, TResponse> where TRequest 
        : IRequest<TResponse>
    {
        protected ICommandCandidateAppService CommandCandidateAppService { get; }

        public CommandHandlerBase(ICommandCandidateAppService commandCandidateAppService)
        {
            CommandCandidateAppService = commandCandidateAppService;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
