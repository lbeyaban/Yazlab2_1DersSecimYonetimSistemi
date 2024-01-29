using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace YazLab1_1
{
    [Table("mesajlar")]
    class Mesajlasma
    {
        [Key]

        [Column("mesajId")]
        public int mesajId { get; set; }

        [Column("gonderenId")]
        public string gonderenId { get; set; }

        [Column("gonderilenId")]
        public string gonderilenId { get; set; }

        [Column("mesaj")]
        public string mesaj { get; set; }

    }
}
