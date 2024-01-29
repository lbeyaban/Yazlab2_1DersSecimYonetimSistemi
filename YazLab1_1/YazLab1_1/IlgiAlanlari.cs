using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("ilgiAlanlari")]
    class IlgiAlanlari
    {
        [Key]

        [Column("ilgiAlaniId")]
        public int ilgiAlaniId { get; set; }

        [Column("ilgiAlaniAdi")]
        public string ilgiAlaniAdi { get; set; }

        [Column("ilgiAlaniAciklama")]
        public string ilgiAlaniAciklama { get; set; }

    }
}
