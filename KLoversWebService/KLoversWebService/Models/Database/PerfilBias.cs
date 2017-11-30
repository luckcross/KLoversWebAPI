using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models.Database
{
    [Table("pbia_perfil_bias", Schema = "klovers")]
    public partial class PerfilBias
    {
        [Column("pbia_id")]
        public int Id { get; set; }

        [Column("pbia_name")]
        public string Name { get; set; }

        [Column("pset_id")]
        public int PerfilSettingsId { get; set; }

        public PerfilSettings PerfilSettings { get; set; }
    }
}
