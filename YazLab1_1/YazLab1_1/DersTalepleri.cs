using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("dersTalepleri")]
    class DersTalepleri
    {
        [Key]
        public int talepId { get; set; }

        [ForeignKey("Ogrenci")]
        public string ogrenciNo { get; set; }

        [ForeignKey("Ogretmen")]
        public string sicilNo { get; set; }

        [ForeignKey("Dersler")]
        public int dersId { get; set; }

        [Column("tablepMesaji")]
        public string talepMesaji { get; set; }

        [Column("talepTarihi")]
        public string talepTarihi { get; set; }

        [Column("Onay")]
        public int onay { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Ogretmen Ogretmen { get; set; }
        public virtual Dersler Dersler { get; set; }


    }
}
