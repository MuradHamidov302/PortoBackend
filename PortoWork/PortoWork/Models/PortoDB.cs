namespace PortoWork.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PortoDB : DbContext
    {
        public PortoDB()
            : base("name=PortoDB2")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_type> User_type { get; set; }
        public virtual DbSet<User1> User1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Blog)
                .HasForeignKey(e => e.blog_id);

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Comments1)
                .WithOptional(e => e.Blog1)
                .HasForeignKey(e => e.blog_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User_type>()
                .HasMany(e => e.User1)
                .WithOptional(e => e.User_type)
                .HasForeignKey(e => e.usertypr_id);

            modelBuilder.Entity<User1>()
                .HasMany(e => e.Blogs)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User1>()
                .HasMany(e => e.Blogs1)
                .WithOptional(e => e.User11)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete();
        }
    }
}
