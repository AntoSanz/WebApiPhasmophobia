using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPhasmophobia.Models
{
    [Table("EQUIPMENT_ES")]
    public class Equipment_ES
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }
    }

    [Table("EQUIPMENT_EN")]
    public class Equipment_EN
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }
    }
}
