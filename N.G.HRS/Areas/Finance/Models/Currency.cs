﻿using N.G.HRS.Areas.Employees.Models;
using N.G.HRS.Areas.PlanningAndJobDescription.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N.G.HRS.Areas.Finance.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string CurrencyName { get; set; }
        [Required]
        [StringLength(70)]
        public string CurrencyCode { get; set; }
        [StringLength(255)]
        public string? CurrencyNotes { get; set; }
        [Required]
        [Range(0, 9999.99)]
        public decimal CurrentPriceOfCurrency { get; set; }
        [Required]
        [Range(0, 9999.99)]
        public decimal PreviousPriceOfCurrency { get; set; }

        //========================================================
        [ForeignKey("FinancialStatementsId")]
        public int FinancialStatementsId { get; set; }
        public FinancialStatements financialStatements { get; set; }
        //=
        [ForeignKey("FunctionalClassId")]
        public int FunctionalClassId { get; set; }
        public FunctionalClass functionalClass { get; set; }

    }
}
