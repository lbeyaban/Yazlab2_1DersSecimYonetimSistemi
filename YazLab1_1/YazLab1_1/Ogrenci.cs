using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YazLab1_1
{
    [Table("ogrenciler")]
    class Ogrenci
    {
        [Key]
        [Column("ogrenciNo")]
        public string ogrenciNo { get; set; }

        [Column("ogrenciAdi")]
        public string ogrenciAdi { get; set; }

        [Column("ogrenciSoyAdi")]
        public string ogrenciSoyAdi { get; set; }

        [Column("ogrenciSifre")]
        public string ogrenciSifre { get; set; }

        [Column("transcriptPdf")]
        public string transcriptPdf { get; set; }

        [Column("ogrenciGenelOrtalama")]
        public double ogrenciGenelOrtalama { get; set; }

    }
}
