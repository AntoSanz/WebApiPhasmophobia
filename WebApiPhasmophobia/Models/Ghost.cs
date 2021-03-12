using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPhasmophobia.Models
{
    [Table("GHOSTS_ES")]
    public class Ghost_ES
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("IDEVIDENCE_1")]
        public int IdEvidence1 { get; set; }
        [Column("IDEVIDENCE_2")]
        public int IdEvidence2 { get; set; }
        [Column("IDEVIDENCE_3")]
        public int IdEvidence3 { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }

    }

    [Table("GHOSTS_EN")]
    public class Ghost_EN
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("IDEVIDENCE_1")]
        public int IdEvidence1 { get; set; }
        [Column("IDEVIDENCE_2")]
        public int IdEvidence2 { get; set; }
        [Column("IDEVIDENCE_3")]
        public int IdEvidence3 { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }

    }
}
