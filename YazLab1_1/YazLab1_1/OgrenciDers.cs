using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace YazLab1_1
{
    [Table("ogrenciDers")]
    class OgrenciDers
    {

        [Key]
        [Column("id")]
        public int id { get; set; }

        [ForeignKey("Ogrenci")]
        public string ogrenciNo { get; set; }

        [ForeignKey("Dersler")]
        public int dersId { get; set; }

        [ForeignKey("Ogretmen")]
        public string sicilNo { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }

        public virtual Dersler Dersler { get; set; }

        public virtual Ogretmen Ogretmen { get; set; }


    }
}
