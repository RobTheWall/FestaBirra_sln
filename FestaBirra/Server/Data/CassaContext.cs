using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FestaBirra.Server.Models
{
    public partial class CassaContext : DbContext
    {
        public CassaContext()
        {
        }

        public CassaContext(DbContextOptions<CassaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CentriDistribuzione> CentriDistribuziones { get; set; }
        public virtual DbSet<Chiusura> Chiusuras { get; set; }
        public virtual DbSet<CodaSm> CodaSms { get; set; }
        public virtual DbSet<Listini> Listinis { get; set; }
        public virtual DbSet<Portate> Portates { get; set; }
        public virtual DbSet<PortateDisponibili> PortateDisponibilis { get; set; }
        public virtual DbSet<PortateListini> PortateListinis { get; set; }
        public virtual DbSet<Storni> Stornis { get; set; }
        public virtual DbSet<Vendite> Vendites { get; set; }
        public virtual DbSet<VenditeDettagli> VenditeDettaglis { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<VwDettagliVenditaByDistribuzione> VwDettagliVenditaByDistribuziones { get; set; }
        public virtual DbSet<VwVenditeDaAperArticolo> VwVenditeDaAperArticolos { get; set; }
        public virtual DbSet<VwVenditeNonChiusePerArticolo> VwVenditeNonChiusePerArticolos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CASSA;Trusted_Connection=True;");
//            }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CentriDistribuzione>(entity =>
            {
                entity.HasKey(e => e.IdCentriDistribuzione)
                    .HasName("PK_CENTRO_DISTRIBUZIONE");

                entity.ToTable("CENTRI_DISTRIBUZIONE");

                entity.Property(e => e.IdCentriDistribuzione)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CENTRI_DISTRIBUZIONE");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIZIONE");
            });

            modelBuilder.Entity<Chiusura>(entity =>
            {
                entity.HasKey(e => e.IdChiusura)
                    .HasName("PK_CHISURA");

                entity.ToTable("CHIUSURA");

                entity.Property(e => e.IdChiusura)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CHIUSURA");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_ORA");

                entity.Property(e => e.Note)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.NumVendite)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("NUM_VENDITE");

                entity.Property(e => e.Operatore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATORE");

                entity.Property(e => e.Totale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTALE");
            });

            modelBuilder.Entity<CodaSm>(entity =>
            {
                entity.ToTable("CODA_SMS");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Datains)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAINS");

                entity.Property(e => e.Datainvio)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAINVIO");

                entity.Property(e => e.Nominativo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMINATIVO");

                entity.Property(e => e.Numero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO");

                entity.Property(e => e.Operatore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATORE");

                entity.Property(e => e.Orains)
                    .HasColumnType("datetime")
                    .HasColumnName("ORAINS");

                entity.Property(e => e.Orainvio)
                    .HasColumnType("datetime")
                    .HasColumnName("ORAINVIO");

                entity.Property(e => e.Stato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATO");

                entity.Property(e => e.TestoSms)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TESTO_SMS");
            });

            modelBuilder.Entity<Listini>(entity =>
            {
                entity.HasKey(e => e.IdListini);

                entity.ToTable("LISTINI");

                entity.Property(e => e.IdListini)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_LISTINI");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIZIONE");
            });

            modelBuilder.Entity<Portate>(entity =>
            {
                entity.HasKey(e => e.IdPortate);

                entity.ToTable("PORTATE");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ID_PORTATE");

                entity.Property(e => e.CodiceMenu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODICE_MENU");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.IdCentriDistribuzione)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_CENTRI_DISTRIBUZIONE");

                entity.Property(e => e.Progressivo).HasColumnName("PROGRESSIVO");
            });

            modelBuilder.Entity<PortateDisponibili>(entity =>
            {
                entity.HasKey(e => e.IdPortate);

                entity.ToTable("PORTATE_DISPONIBILI");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_Portate");

                entity.Property(e => e.Disponibile).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PortateListini>(entity =>
            {
                entity.HasKey(e => new { e.IdPortate, e.IdListini });

                entity.ToTable("PORTATE_LISTINI");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PORTATE");

                entity.Property(e => e.IdListini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_LISTINI");

                entity.Property(e => e.Prezzo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PREZZO");
            });

            modelBuilder.Entity<Storni>(entity =>
            {
                entity.HasKey(e => e.IdStorni);

                entity.ToTable("STORNI");

                entity.Property(e => e.IdStorni).HasColumnName("ID_Storni");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Ora");

                entity.Property(e => e.IdOperatore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_OPERATORE");

                entity.Property(e => e.IdVenditeDettagli)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_Vendite_Dettagli");

                entity.Property(e => e.Prezzo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qta).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Vendite>(entity =>
            {
                entity.HasKey(e => e.IdVendite)
                    .HasName("PK_Tabella1");

                entity.ToTable("VENDITE");

                entity.Property(e => e.IdVendite)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_VENDITE");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_ORA");

                entity.Property(e => e.IdCassa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_CASSA");

                entity.Property(e => e.IdChiusura)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_CHIUSURA");

                entity.Property(e => e.IdListino)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_LISTINO");

                entity.Property(e => e.IdPersona)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PERSONA");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Pagato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PAGATO");

                entity.Property(e => e.Resto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RESTO");

                entity.Property(e => e.Totale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTALE");
            });

            modelBuilder.Entity<VenditeDettagli>(entity =>
            {
                entity.HasKey(e => e.IdVenditeDettagli)
                    .HasName("PK_VENDITE");

                entity.ToTable("VENDITE_DETTAGLI");

                entity.HasIndex(e => e.IdVendite, "IX_VENDITE_DETTAGLI");

                entity.Property(e => e.IdVenditeDettagli)
                    .HasColumnType("decimal(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_VENDITE_DETTAGLI");

                entity.Property(e => e.CodiceMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODICE_MENU");

                entity.Property(e => e.Consegnato).HasColumnName("CONSEGNATO");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_ORA");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.IdCassa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_CASSA");

                entity.Property(e => e.IdListino)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_LISTINO");

                entity.Property(e => e.IdPersona)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PERSONA");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PORTATE");

                entity.Property(e => e.IdVendite)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_VENDITE");

                entity.Property(e => e.Prezzo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PREZZO");

                entity.Property(e => e.Qta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QTA");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.TotEuro)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("tot_euro");

                entity.Property(e => e.TotQta)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("tot_qta");
            });

            modelBuilder.Entity<VwDettagliVenditaByDistribuzione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DettagliVenditaByDistribuzione");

                entity.Property(e => e.CodiceMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODICE_MENU");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_ORA");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIZIONE");

                entity.Property(e => e.IdCassa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_CASSA");

                entity.Property(e => e.IdVenditeDettagli)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ID_VENDITE_DETTAGLI");

                entity.Property(e => e.Qta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QTA");
            });

            modelBuilder.Entity<VwVenditeDaAperArticolo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VenditeDaAPerArticolo");

                entity.Property(e => e.CodiceMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODICE_MENU");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.Disponibile).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PORTATE");

                entity.Property(e => e.QtaVendute)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("QTA_VENDUTE");

                entity.Property(e => e.SaldoQta).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VwVenditeNonChiusePerArticolo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_VenditeNonChiusePerArticolo");

                entity.Property(e => e.CodiceMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODICE_MENU");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI");

                entity.Property(e => e.Disponibile).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdPortate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ID_PORTATE");

                entity.Property(e => e.QtaVendute)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("QTA_VENDUTE");

                entity.Property(e => e.SaldoQta).HasColumnType("decimal(38, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
