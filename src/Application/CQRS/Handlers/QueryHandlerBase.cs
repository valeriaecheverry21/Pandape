using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public abstract class QueryHandlerBase<TRequest, TResponse> 
        : IRequestHandler<TRequest, TResponse> where TRequest 
        : IRequest<TResponse>
    {
        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
