﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models
{
    [Table("dona_donation")]
    public partial class Donation
    {
        [Column("dona_id")]
        public int Id { get; set; }

        [Column("dona_value")]
        public decimal Value { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser Ause { get; set; }
    }
}
