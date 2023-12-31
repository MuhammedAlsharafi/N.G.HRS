﻿using System.ComponentModel.DataAnnotations;

namespace N.G.HRS.Areas.OrganizationalChart.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }
        [Required]
        [StringLength(150)]
        public string CompanyName { get; set; }
        [Required]
        [Range(0, 13)]
        public int LicenseNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeOfBusinessActivity { get; set; }
        [Required]
        [StringLength(255)]
        public string ComponyLogo { get; set; }
        [Required]
        [StringLength(255)]
        public string ComponyAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string? Notes { get; set; }
        //====================================================================
        public List<BoardOfDirectors> BoardOfDirectorsList { get; set;}
        public List<Branches> branchesList { get; set; }
        //====================================================================


    }
}
