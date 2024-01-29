namespace YazLab1_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yazlab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.dersler",
                c => new
                    {
                        dersId = c.Int(nullable: false, identity: true),
                        dersAdi = c.String(),
                        dersAciklama = c.String(),
                    })
                .PrimaryKey(t => t.dersId);
            
            CreateTable(
                "public.dersTalepleri",
                c => new
                    {
                        talepId = c.Int(nullable: false, identity: true),
                        ogrenciNo = c.String(maxLength: 128),
                        sicilNo = c.String(maxLength: 128),
                        dersId = c.Int(nullable: false),
                        tablepMesaji = c.String(),
                        talepTarihi = c.String(),
                        Onay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.talepId)
                .ForeignKey("public.dersler", t => t.dersId, cascadeDelete: true)
                .ForeignKey("public.ogrenciler", t => t.ogrenciNo)
                .ForeignKey("public.ogretmenler", t => t.sicilNo)
                .Index(t => t.ogrenciNo)
                .Index(t => t.sicilNo)
                .Index(t => t.dersId);
            
            CreateTable(
                "public.ogrenciler",
                c => new
                    {
                        ogrenciNo = c.String(nullable: false, maxLength: 128),
                        ogrenciAdi = c.String(),
                        ogrenciSoyAdi = c.String(),
                        ogrenciSifre = c.String(),
                        transcriptPdf = c.String(),
                        ogrenciGenelOrtalama = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ogrenciNo);
            
            CreateTable(
                "public.ogretmenler",
                c => new
                    {
                        sicilNo = c.String(nullable: false, maxLength: 128),
                        ogretmenAdi = c.String(),
                        ogretmenSoyad = c.String(),
                        ogretmenSifre = c.String(),
                        kontenjan = c.String(),
                    })
                .PrimaryKey(t => t.sicilNo);
            
            CreateTable(
                "public.genelAyarlar",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        mesajKarakterSiniri = c.Int(nullable: false),
                        dersSecimSüresi = c.Int(nullable: false),
                        farkliHocadanAlabilirMi = c.Int(nullable: false),
                        asama = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.ilgiAlaniOgretmen",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sicilNo = c.String(maxLength: 128),
                        ilgiAlaniId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.ilgiAlanlari", t => t.ilgiAlaniId, cascadeDelete: true)
                .ForeignKey("public.ogretmenler", t => t.sicilNo)
                .Index(t => t.sicilNo)
                .Index(t => t.ilgiAlaniId);
            
            CreateTable(
                "public.ilgiAlanlari",
                c => new
                    {
                        ilgiAlaniId = c.Int(nullable: false, identity: true),
                        ilgiAlaniAdi = c.String(),
                        ilgiAlaniAciklama = c.String(),
                    })
                .PrimaryKey(t => t.ilgiAlaniId);
            
            CreateTable(
                "public.ilgiAlaniOgrenci",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ogrenciNo = c.String(maxLength: 128),
                        ilgiAlaniId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.ilgiAlanlari", t => t.ilgiAlaniId, cascadeDelete: true)
                .ForeignKey("public.ogrenciler", t => t.ogrenciNo)
                .Index(t => t.ogrenciNo)
                .Index(t => t.ilgiAlaniId);
            
            CreateTable(
                "public.kriterDersListesi",
                c => new
                    {
                        dersId = c.Int(nullable: false, identity: true),
                        dersId1 = c.Int(nullable: false),
                        sicilNo = c.String(maxLength: 128),
                        katsayisi = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.dersId)
                .ForeignKey("public.dersler", t => t.dersId1, cascadeDelete: true)
                .ForeignKey("public.ogretmenler", t => t.sicilNo)
                .Index(t => t.dersId1)
                .Index(t => t.sicilNo);
            
            CreateTable(
                "public.mesajlar",
                c => new
                    {
                        mesajId = c.Int(nullable: false, identity: true),
                        gonderenId = c.String(),
                        gonderilenId = c.String(),
                        mesaj = c.String(),
                    })
                .PrimaryKey(t => t.mesajId);
            
            CreateTable(
                "public.ogrenciDers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ogrenciNo = c.String(maxLength: 128),
                        dersId = c.Int(nullable: false),
                        sicilNo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.dersler", t => t.dersId, cascadeDelete: true)
                .ForeignKey("public.ogrenciler", t => t.ogrenciNo)
                .ForeignKey("public.ogretmenler", t => t.sicilNo)
                .Index(t => t.ogrenciNo)
                .Index(t => t.dersId)
                .Index(t => t.sicilNo);
            
            CreateTable(
                "public.ogretmenDers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sicilNo = c.String(maxLength: 128),
                        dersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.dersler", t => t.dersId, cascadeDelete: true)
                .ForeignKey("public.ogretmenler", t => t.sicilNo)
                .Index(t => t.sicilNo)
                .Index(t => t.dersId);
            
            CreateTable(
                "public.transcript",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dersId = c.Int(nullable: false),
                        ogrenciNo = c.String(maxLength: 128),
                        dersNotu = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.dersler", t => t.dersId, cascadeDelete: true)
                .ForeignKey("public.ogrenciler", t => t.ogrenciNo)
                .Index(t => t.dersId)
                .Index(t => t.ogrenciNo);
            
            CreateTable(
                "public.yoneticiler",
                c => new
                    {
                        yoneticiNo = c.String(nullable: false, maxLength: 128),
                        yoneticiAdi = c.String(),
                        yoneticiSifre = c.String(),
                    })
                .PrimaryKey(t => t.yoneticiNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.transcript", "ogrenciNo", "public.ogrenciler");
            DropForeignKey("public.transcript", "dersId", "public.dersler");
            DropForeignKey("public.ogretmenDers", "sicilNo", "public.ogretmenler");
            DropForeignKey("public.ogretmenDers", "dersId", "public.dersler");
            DropForeignKey("public.ogrenciDers", "sicilNo", "public.ogretmenler");
            DropForeignKey("public.ogrenciDers", "ogrenciNo", "public.ogrenciler");
            DropForeignKey("public.ogrenciDers", "dersId", "public.dersler");
            DropForeignKey("public.kriterDersListesi", "sicilNo", "public.ogretmenler");
            DropForeignKey("public.kriterDersListesi", "dersId1", "public.dersler");
            DropForeignKey("public.ilgiAlaniOgrenci", "ogrenciNo", "public.ogrenciler");
            DropForeignKey("public.ilgiAlaniOgrenci", "ilgiAlaniId", "public.ilgiAlanlari");
            DropForeignKey("public.ilgiAlaniOgretmen", "sicilNo", "public.ogretmenler");
            DropForeignKey("public.ilgiAlaniOgretmen", "ilgiAlaniId", "public.ilgiAlanlari");
            DropForeignKey("public.dersTalepleri", "sicilNo", "public.ogretmenler");
            DropForeignKey("public.dersTalepleri", "ogrenciNo", "public.ogrenciler");
            DropForeignKey("public.dersTalepleri", "dersId", "public.dersler");
            DropIndex("public.transcript", new[] { "ogrenciNo" });
            DropIndex("public.transcript", new[] { "dersId" });
            DropIndex("public.ogretmenDers", new[] { "dersId" });
            DropIndex("public.ogretmenDers", new[] { "sicilNo" });
            DropIndex("public.ogrenciDers", new[] { "sicilNo" });
            DropIndex("public.ogrenciDers", new[] { "dersId" });
            DropIndex("public.ogrenciDers", new[] { "ogrenciNo" });
            DropIndex("public.kriterDersListesi", new[] { "sicilNo" });
            DropIndex("public.kriterDersListesi", new[] { "dersId1" });
            DropIndex("public.ilgiAlaniOgrenci", new[] { "ilgiAlaniId" });
            DropIndex("public.ilgiAlaniOgrenci", new[] { "ogrenciNo" });
            DropIndex("public.ilgiAlaniOgretmen", new[] { "ilgiAlaniId" });
            DropIndex("public.ilgiAlaniOgretmen", new[] { "sicilNo" });
            DropIndex("public.dersTalepleri", new[] { "dersId" });
            DropIndex("public.dersTalepleri", new[] { "sicilNo" });
            DropIndex("public.dersTalepleri", new[] { "ogrenciNo" });
            DropTable("public.yoneticiler");
            DropTable("public.transcript");
            DropTable("public.ogretmenDers");
            DropTable("public.ogrenciDers");
            DropTable("public.mesajlar");
            DropTable("public.kriterDersListesi");
            DropTable("public.ilgiAlaniOgrenci");
            DropTable("public.ilgiAlanlari");
            DropTable("public.ilgiAlaniOgretmen");
            DropTable("public.genelAyarlar");
            DropTable("public.ogretmenler");
            DropTable("public.ogrenciler");
            DropTable("public.dersTalepleri");
            DropTable("public.dersler");
        }
    }
}
