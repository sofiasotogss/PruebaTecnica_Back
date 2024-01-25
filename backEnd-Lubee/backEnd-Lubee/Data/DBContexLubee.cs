using Microsoft.EntityFrameworkCore;

namespace backEnd_Lubee.Data
{
    public class DBContexLubee :DbContext
    {
        public DBContexLubee(DbContextOptions<DBContexLubee> options): base(options)
        {
            
        }

        DbSet<Contrato> _Contrato;
        DbSet<DetalleContrato> _DetalleContrato;
        DbSet<Producto> _Producto;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contrato>()
                .Property(c => c.CourseCode)
                .IsRequired()
                .HasMaxLength(6)
                .HasColumnType("varchar(6)");


            modelBuilder.Entity<Contrato>()
                .Property(c => c.MedioEntrega)
                .HasMaxLength(150);

            modelBuilder.Entity<Contrato>()
                .Property(c => c.Vendedor)
                .HasMaxLength(150);

            modelBuilder.Entity<Contrato>()
                .Property(c => c.ColegioNivel)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Contrato>()
                .Property(c => c.ColegioNombre)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<Contrato>()
                .Property(c => c.ColegioCurso)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<Contrato>()
                .Property(c => c.ColegioLocalidad)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<DetalleContrato>()
                .HasOne(dc => dc.IdContrato)
                .WithMany()
                .HasForeignKey(dc => dc.ContratoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleContrato>()
                .HasOne(dc => dc.IdProducto)
                .WithMany()
                .HasForeignKey(dc => dc.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleContrato>()
                .Property(dc => dc.CreateBy)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Producto>()
                .Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
        }
    }

}

