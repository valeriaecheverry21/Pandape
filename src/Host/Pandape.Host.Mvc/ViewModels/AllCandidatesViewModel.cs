using System.Collections.Generic;

namespace Pandape.Host.Mvc.ViewModels
{
    public class AllCandidatesViewModel
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string BirthDate { get; set; }

        public string Email { get; set; }

        public string InsertDate { get; set; }

        public string ModifyDate { get; set; }

        public List<CandidateViewModel> Candidates { get; set; }
    }
}
