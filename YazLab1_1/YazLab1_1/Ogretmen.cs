using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("ogretmenler")]
    public class Ogretmen
    {
        [Key]
        [Column("sicilNo")]
        public string sicilNo { get; set; }

        [Column("ogretmenAdi")]
        public string ogretmenAdi { get; set; }

        [Column("ogretmenSoyad")]
        public string ogretmenSoyAdi { get; set; }

        [Column("ogretmenSifre")]
        public string ogretmenSifre { get; set;}

        [Column("kontenjan")]
        public string kontenjan { get; set; }


    }
}
