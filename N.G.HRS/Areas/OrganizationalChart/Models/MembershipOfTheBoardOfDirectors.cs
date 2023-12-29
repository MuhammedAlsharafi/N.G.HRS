﻿using System.ComponentModel.DataAnnotations;

namespace N.G.HRS.Areas.OrganizationalChart.Models
{
    public class MembershipOfTheBoardOfDirectors
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string TypeOFMembership { get; set; }
        [Required]
        [StringLength(255)]
        public string? Notes { get; set; }

    }
}