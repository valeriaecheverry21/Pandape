using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pandape.Domain.Entities
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string SurName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime InsertDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Navigation property
        /// </summary>
        public ICollection<CandidateExperience> CandidateExperiences { get; set; }
    }
}
