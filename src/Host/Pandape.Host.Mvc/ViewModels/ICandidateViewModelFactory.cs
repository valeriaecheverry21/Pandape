
using Pandape.Application.CQRS.Responses;

namespace Pandape.Host.Mvc.ViewModels
{
    public interface ICandidateViewModelFactory 
    {
        AllCandidatesViewModel GetAll(GetAllCandidatesResponse AllCandidatesResponse);

        DetailsCandidateViewModel Details(GetDetailsCandidateResponse DetailsCandidateResponse);

        DetailsCandidateAndExperiencesViewModel Details(GetDetailsCandidateAndExperiencesResponse DetailsCandidateExperiencesResponse);

        EditCandidateViewModel Edit(GetByIdCandidateResponse getByIdCandidateResponse);

        DeleteCandidateViewModel Delete(GetByIdCandidateResponse getByIdCandidateResponse);
    }
}
