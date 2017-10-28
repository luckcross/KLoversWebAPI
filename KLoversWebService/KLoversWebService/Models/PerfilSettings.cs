using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models
{
    [Table("pset_perfil_settings")]
    public partial class PerfilSettings
    {
        [Column("pset_id")]
        public int Id { get; set; }

        [Column("pset_visible_status")]
        public int VisibleStatus { get; set; }

        [Column("pset_sex")]
        public string Sex { get; set; }

        [Column("pset_description")]
        public string Description { get; set; }

        [Column("pset_age")]
        public int Age { get; set; }

        [Column("pset_city")]
        public string City { get; set; }

        [Column("ause_id")]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<PerfilBias> PerfilBias { get; set; }

        public ICollection<PerfilPhoto> PerfilPhoto { get; set; }

        public PerfilSettings()
        {
            PerfilBias = new HashSet<PerfilBias>();
            PerfilPhoto = new HashSet<PerfilPhoto>();
        }
    }
}
