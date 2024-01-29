using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("genelAyarlar")]
    class GenelAyarlar
    {
        [Key]
        public int id { get; set; }

        [Column("mesajKarakterSiniri")]
        public int mesajKarakterSiniri { get; set; }

        [Column("dersSecimSüresi")]
        public int dersSecimSüresi { get; set; }

        [Column("farkliHocadanAlabilirMi")]
        public int farkliHocadanAlabilirMi { get; set; }

        [Column("asama")]
        public int asama { get; set; }


    }
}
