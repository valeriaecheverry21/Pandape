using System.Collections.Generic;

namespace Pandape.Host.Mvc.ViewModels
{
    public class DetailsCandidateAndExperiencesViewModel
    {

        public CandidateViewModel Candidate { get; set; }

        public CandidateExperienceViewModel CandidateExperience { get; set; }

        public IEnumerable<CandidateExperienceViewModel> CandidateExperiences { get; set; }
    }
}
