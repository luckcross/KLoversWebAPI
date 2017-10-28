using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models
{
    [Table("matc_match")]
    public partial class Match
    {
        [Column("matc_id")]
        public int Id { get; set; }

        [Column("matc_date")]
        public DateTime Date { get; set; }

        [Column("inte_id__one")]
        public int InterestIdOne { get; set; }

        [Column("inte_id__two")]
        public int InterestIdTwo { get; set; }

        public Interest InterestOne { get; set; }

        public Interest InterestTwo { get; set; }
    }
}
