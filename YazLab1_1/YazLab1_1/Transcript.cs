using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace YazLab1_1
{
    [Table("transcript")]
    class Transcript
    {
        [Key]

        [Column("id")]
        public int id { get; set; }

        [ForeignKey("Dersler")]
        public int dersId { get; set; }

        [ForeignKey("Ogrenci")]
        public string ogrenciNo { get; set; }

        [Column("dersNotu")]
        public double dersNotu { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }

        public virtual Dersler Dersler { get; set; }

    }
}
