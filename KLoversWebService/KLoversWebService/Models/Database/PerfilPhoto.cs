using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLoversWebService.Models.Database
{
    [Table("ppho_perfil_photo", Schema = "klovers")]
    public partial class PerfilPhoto
    {
        [Column("ppho_id")]
        public int Id { get; set; }

        [Column("ppho_dire")]
        public string Dir { get; set; }

        [Column("ppho_position")]
        public int Position { get; set; }

        [Column("pset_id")]
        public int PerfilSettingsId { get; set; }

        public PerfilSettings PerfilSettings { get; set; }
    }
}
