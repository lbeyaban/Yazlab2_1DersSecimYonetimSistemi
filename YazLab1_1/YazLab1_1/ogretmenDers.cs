using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("ogretmenDers")]
    class OgretmenDers
    {

        [Key]
        [Column("id")]
        public int id { get; set; }

        [ForeignKey("Ogretmen")]
        public string sicilNo { get; set; }

        [ForeignKey("Dersler")]
        public int dersId { get; set; }

        public virtual Ogretmen Ogretmen { get; set; }

        public virtual Dersler Dersler { get; set; }


    }
}
