using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLoversWebService.Models
{
    [Table("facu_facebook_user")]
    public class FacebookUser
    {
        [Column("facu_id")]
        public int Id { get; set; }

        [Column("facu_username")]
        public string Username { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser Ause { get; set; }

    }
}
