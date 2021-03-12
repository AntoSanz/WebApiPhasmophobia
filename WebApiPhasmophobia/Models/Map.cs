using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPhasmophobia.Models
{
    [Table("MAP_ES")]
    public class Map_ES
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }
        [Column("IMG")]
        public String Img { get; set; }
        [Column("SIZE")]
        public String Size { get; set; }

    }

    [Table("MAP_EN")]
    public class Map_EN
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPT")]
        public String Descript { get; set; }
        [Column("IMG")]
        public String Img { get; set; }
        [Column("SIZE")]
        public String Size { get; set; }

    }
}
