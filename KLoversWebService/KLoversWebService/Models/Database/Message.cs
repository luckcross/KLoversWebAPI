using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models.Database
{
    [Table("mess_message", Schema = "klovers")]
    public partial class Message
    {
        [Column("mess_id")]
        public int Id { get; set; }

        [Column("mess_text")]
        public string Text { get; set; }

        [Column("mess_creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("mess_read_date")]
        public DateTime? ReadDate { get; set; }

        [Column("ause_id__from")]
        public int AppUserIdFrom { get; set; }

        [Column("ause_id__to")]
        public int AppUserIdTo { get; set; }

        public AppUser AppUserFrom { get; set; }
        public AppUser AppUserTo { get; set; }
    }
}
