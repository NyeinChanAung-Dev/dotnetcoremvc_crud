using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotnetcoremvc_crud.Model
{
    public partial class dotnetcoremvc_crudContext : DbContext
    {
        public dotnetcoremvc_crudContext()
        {
        }

        public dotnetcoremvc_crudContext(DbContextOptions<dotnetcoremvc_crudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-01F9C8A;Initial Catalog=dotnetcoremvc_crud;Persist Security Info=True;User ID=sa;Password=2good2btrue;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(80);

                entity.Property(e => e.Country).HasMaxLength(80);

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
