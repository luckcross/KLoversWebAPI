using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models.Database
{
    [Table("inte_interest", Schema = "klovers")]
    public partial class Interest
    {
        [Column("inte_id")]
        public int Id { get; set; }

        [Column("inte_creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("inte_read_date")]
        public DateTime? ReadDate { get; set; }

        [Column("inte_type_number")]
        public int TypeNumber { get; set; }

        [Column("inte_match_status")]
        public bool MatchStatus { get; set; }

        [Column("ause_id__from")]
        public int AppUserIdFrom { get; set; }

        [Column("ause_id__to")]
        public int AppUserIdTo { get; set; }

        public AppUser AppUserFrom { get; set; }

        public AppUser AppUserTo { get; set; }

        public ICollection<Match> MatchOne { get; set; }

        public ICollection<Match> MatchTwo{ get; set; }

        public Interest()
        {
            MatchOne = new HashSet<Match>();
            MatchTwo = new HashSet<Match>();
        }
    }
}
