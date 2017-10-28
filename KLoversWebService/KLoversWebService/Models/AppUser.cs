using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLoversWebService.Models
{
    [Table("ause_app_user")]
    public class AppUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("ause_id")]
        public int Id { get; set; }

        [Required]
        [Column("ause_creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("ause_last_login_date")]
        public DateTime? LastLoginDate { get; set; }

        [Required]
        [Column("ause_active")]
        public bool Active { get; set; }

        public ICollection<AccountSettings> AccountSettings { get; set; }

        public ICollection<Donation> Donation { get; set; }

        public ICollection<FacebookUser> FacebookUser { get; set; }

        public ICollection<Interest> InterestIdFrom { get; set; }

        public ICollection<Interest> InterestIdTo { get; set; }

        public ICollection<Message> MessageFrom { get; set; }

        public ICollection<Message> MessageTo { get; set; }

        public ICollection<PerfilSettings> PerfilSettings { get; set; }

        public ICollection<RankWall> RankWall { get; set; }

        public ICollection<UserPurchase> UserPurchase { get; set; }

        public AppUser()
        {
            AccountSettings = new HashSet<AccountSettings>();
            Donation = new HashSet<Donation>();
            FacebookUser = new HashSet<FacebookUser>();
            InterestIdFrom = new HashSet<Interest>();
            InterestIdTo = new HashSet<Interest>();
            MessageFrom = new HashSet<Message>();
            MessageTo = new HashSet<Message>();
            PerfilSettings = new HashSet<PerfilSettings>();
            RankWall = new HashSet<RankWall>();
            UserPurchase = new HashSet<UserPurchase>();
        }

        
    }
}
