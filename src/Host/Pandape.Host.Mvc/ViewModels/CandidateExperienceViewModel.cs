using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pandape.Host.Mvc.ViewModels
{
    public class CandidateExperienceViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Company { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Job { get; set; }

        [Required]
        [Column(TypeName = "varchar(4000)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InsertDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ModifyDate { get; set; }

        public int CandidateId { get; set; }

        public CandidateViewModel Candidate { get; set; }
    }
}
