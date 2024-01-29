using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace YazLab1_1
{
    class Context : DbContext
    {
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Dersler> Dersler { get; set; }
        public DbSet<IlgiAlanlari> IlgiAlanlari { get; set; }
        public DbSet<IlgiAlaniOgretmen> IlgiAlaniOgretmens { get; set; }
        public DbSet<IlgiAlanlarıOgrenci> IlgiAlanlarıOgrencis { get; set; }
        public DbSet<DersTalepleri> DersTalepleris { get; set; }
        public DbSet<GenelAyarlar> GenelAyarlars { get; set; }
        public DbSet<OgretmenDers> OgretmenDers { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<Yonetici> Yoneticis { get; set; }
        public DbSet<KriterDersListesi> KriterDersListesis { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<Mesajlasma> Mesajlasmas { get; set; }


        public Context() : base(nameOrConnectionString: "PostgreConn") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

        }







    }
}
