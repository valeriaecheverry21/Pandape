using AutoMapper;
using Pandape.Application.CQRS.Responses;
using System.Collections.Generic;
using System.Linq;

namespace Pandape.Host.Mvc.ViewModels
{
    public class CandidateViewModelFactory : ViewModelFactoryBase, ICandidateViewModelFactory
    {
        public CandidateViewModelFactory(IMapper mapper) : base(mapper)
        {
        }

        public AllCandidatesViewModel GetAll(GetAllCandidatesResponse response)
        {
            var viewModel = new AllCandidatesViewModel();

            viewModel.Candidates = Mapper.Map<IEnumerable<CandidateViewModel>>(response.CandidatesDto).ToList();

            return viewModel;
        }

        public DetailsCandidateViewModel Details(GetDetailsCandidateResponse response)
        {
            var viewModel = new DetailsCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            return viewModel;
        }

        public DetailsCandidateAndExperiencesViewModel Details(GetDetailsCandidateAndExperiencesResponse response)
        {
            var viewModel = new DetailsCandidateAndExperiencesViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            viewModel.CandidateExperiences = Mapper.Map<IEnumerable<CandidateExperienceViewModel>>(response.CandidateExperienceDto.ToList());

            return viewModel;
        }

        public EditCandidateViewModel Edit(GetByIdCandidateResponse response)
        {
            var viewModel = new EditCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            return viewModel;
        }

        public DeleteCandidateViewModel Delete(GetByIdCandidateResponse response)
        {
            var viewModel = new DeleteCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            return viewModel;
        }
    }
}