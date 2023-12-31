﻿using N.G.HRS.Areas.Employees.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N.G.HRS.Areas.GeneralConfiguration.Models
{
    public class FunctionalFiles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string FileName { get; set; }
        [StringLength(255)]
        public string? Notes { get; set; }
        //===============================================
        [ForeignKey("StatementOfEmployeeFilesId")]
        public int StatementOfEmployeeFilesId { get; set; }
        public StatementOfEmployeeFiles statementOfEmployeeFiles { get; set; }
    }
}
