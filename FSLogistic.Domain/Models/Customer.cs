using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Customer : BaseEntityModel
    {
        [Required]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public decimal? Q1 { get; set; }

        public decimal? Q2 { get; set; }

        public decimal? Q3 { get; set; }

        public decimal? Q4 { get; set; }

        public decimal? Q5 { get; set; }

        public decimal? Q6 { get; set; }

        public decimal? Q7 { get; set; }

        public decimal? Q8 { get; set; }

        public decimal? Q9 { get; set; }

        public decimal? Q10 { get; set; }

        public decimal? Q11 { get; set; }

        public decimal? Q12 { get; set; }

        public decimal? QTD { get; set; }

        public decimal? QGV { get; set; }

        public decimal? QBTH { get; set; }

        public decimal? QTB { get; set; }

        public decimal? QTP { get; set; }

        public decimal? QBTN { get; set; }

        public decimal? QPN { get; set; }

        public decimal? Qcc { get; set; }

        public decimal? QHM { get; set; }

        public decimal? QBC { get; set; }

        public decimal? QNB { get; set; }

        public decimal? QCG { get; set; }
    }
}
