using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public interface ICommandCandidateAppService
    {
        Task<InsertCandidateResponse> Insert(InsertCandidateCommand command);

        Task<UpdateCandidateResponse> Update(UpdateCandidateCommand command);

        Task<DeleteCandidateResponse> Delete(DeleteCandidateCommand command);
    }
}
