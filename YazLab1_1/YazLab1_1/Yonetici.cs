using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("yoneticiler")]
    class Yonetici
    {
        [Key]
        [Column("yoneticiNo")]
        public string yoneticiNo { get; set; }

        [Column("yoneticiAdi")]
        public string yoneticiAdi { get; set; }

        [Column("yoneticiSifre")]
        public string yoneticiSifre { get; set; }


    }
}
