using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models.Database
{
    [Table("aset_account_settings", Schema = "klovers")]
    public partial class AccountSettings
    {
        [Column("aset_id")]
        public int Id { get; set; }

        [Column("aset_app_language")]
        public string AppLanguage { get; set; }

        [Column("aset_notif_msg_status")]
        public bool NotifMsgStatus { get; set; }

        [Column("aset_notif_match_status")]
        public bool NotifMatchStatus { get; set; }

        [Column("aset_notif_super_like")]
        public bool NotifSuperLike { get; set; }

        [Column("aset_active")]
        public bool Active { get; set; }

        [Column("aset_max_distance")]
        public int MaxDistance { get; set; }

        [Column("aset_min_distance")]
        public int MinDistance { get; set; }

        [Column("aset_search_sex")]
        public string SearchSex { get; set; }

        [Column("aset_min_age")]
        public int MinAge { get; set; }

        [Column("aset_max_age")]
        public int MaxAge { get; set; }

        [Column("aset_coin")]
        public int Coins { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
