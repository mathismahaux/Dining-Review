using Microsoft.EntityFrameworkCore;
using DiningReview.Models;

namespace DiningReview.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Models.DiningReview> DiningReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(u => u.DisplayName).HasColumnName("display_name");
                entity.Property(u => u.City).HasColumnName("city");
                entity.Property(u => u.State).HasColumnName("state");
                entity.Property(u => u.Zipcode).HasColumnName("zipcode");
                entity.Property(u => u.InterestedInPeanutAllergy).HasColumnName("interested_in_peanut_allergy");
                entity.Property(u => u.InterestedInEggAllergy).HasColumnName("interested_in_egg_allergy");
                entity.Property(u => u.InterestedInDairyAllergy).HasColumnName("interested_in_dairy_allergy");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("restaurants");
                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.Name).HasColumnName("name");
                entity.Property(r => r.Address).HasColumnName("address");
                entity.Property(r => r.Zipcode).HasColumnName("zipcode");
                entity.Property(r => r.PeanutScore).HasColumnName("peanut_score");
                entity.Property(r => r.EggScore).HasColumnName("egg_score");
                entity.Property(r => r.DairyScore).HasColumnName("dairy_score");
                entity.Property(r => r.OverallScore).HasColumnName("overall_score");
            });

            modelBuilder.Entity<Models.DiningReview>(entity =>
            {
                entity.ToTable("dining_reviews");
                entity.Property(dr => dr.Id).HasColumnName("id");
                entity.Property(dr => dr.SubmittedBy).HasColumnName("submitted_by");
                entity.Property(dr => dr.RestaurantId).HasColumnName("restaurant_id");
                entity.Property(dr => dr.PeanutScore).HasColumnName("peanut_score");
                entity.Property(dr => dr.EggScore).HasColumnName("egg_score");
                entity.Property(dr => dr.DairyScore).HasColumnName("dairy_score");
                entity.Property(dr => dr.Commentary).HasColumnName("commentary");
                entity.Property(dr => dr.Status).HasColumnName("status");

                entity.Property(dr => dr.Status)
                    .HasColumnName("status")
                    .HasConversion<string>();
            });
        }
    }
}