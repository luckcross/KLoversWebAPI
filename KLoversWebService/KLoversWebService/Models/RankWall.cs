using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models
{
    [Table("rwal_rank_wall")]
    public partial class RankWall
    {
        [Column("rwal_id")]
        public int Id { get; set; }

        [Column("rwal_start_date")]
        public DateTime StartDate { get; set; }

        [Column("rwal_end_date")]
        public DateTime EndDate { get; set; }

        [Column("rwal_type")]
        public string Type { get; set; }

        [Column("rwal_quantity_number")]
        public int QuantityNumber { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
