namespace Dosug.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direction>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Direction)
                .HasForeignKey(e => e.EventDirection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.EventTime)
                .HasPrecision(5);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Gender)
                .HasForeignKey(e => e.UserGender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPhone)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
