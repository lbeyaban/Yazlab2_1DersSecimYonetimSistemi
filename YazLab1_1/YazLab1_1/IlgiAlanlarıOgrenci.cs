using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("ilgiAlaniOgrenci")]
    class IlgiAlanlarıOgrenci
    {

        [Key]
        [Column("id")]
        public int id { get; set; }

        [ForeignKey("Ogrenci")]
        public string ogrenciNo { get; set; }

        [ForeignKey("IlgiAlanlari")]
        public int ilgiAlaniId { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }

        public virtual IlgiAlanlari IlgiAlanlari { get; set; }


    }
}
