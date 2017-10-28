using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models
{
    [Table("upur_user_purchase")]
    public partial class UserPurchase
    {
        [Column("upur_id")]
        public int Id { get; set; }

        [Column("upur_date")]
        public DateTime Date { get; set; }

        [Column("upur_value")]
        public decimal Value { get; set; }

        [Column("upur_item")]
        public int Item { get; set; }

        [Column("upur_count")]
        public int Count { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
