using System;
using System.Collections.Generic;

namespace Pandape.Application.Dtos
{
    public class CandidateDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public List<CandidateExperienceDto> CandidateExperiencesList { get; set; }
    }
}
