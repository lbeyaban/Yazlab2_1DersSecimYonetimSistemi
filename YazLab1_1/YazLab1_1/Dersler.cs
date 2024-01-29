using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("dersler")]
    class Dersler
    {
        [Key]

        [Column("dersId")]
        public int dersId { get; set; }

        [Column("dersAdi")]
        public string dersAdi { get; set; }

        [Column("dersAciklama")]
        public string dersAciklama { get; set; }


    }
}
