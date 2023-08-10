using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Models;

public partial class TourismContext : DbContext
{
    public TourismContext()
    {
    }

    public TourismContext(DbContextOptions<TourismContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminImageUpload> AdminImageUploads { get; set; }

    public virtual DbSet<BookingTrip> BookingTrips { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<ItineraryDetail> ItineraryDetails { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminImageUpload>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__AdminIma__7516F70C93BF47EB");

            entity.ToTable("AdminImageUpload");

            entity.HasOne(d => d.User).WithMany(p => p.AdminImageUploads)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__AdminImag__UserI__4BAC3F29");
        });

        modelBuilder.Entity<BookingTrip>(entity =>
        {
            entity.HasKey(e => e.BookingTripid).HasName("PK__BookingT__5AF2DFD176205029");

            entity.ToTable("BookingTrip");

            entity.Property(e => e.DateOfTheTrip).HasColumnType("date");
            entity.Property(e => e.DateofBooking)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.Hotel).WithMany(p => p.BookingTrips)
                .HasForeignKey(d => d.Hotelid)
                .HasConstraintName("FK__BookingTr__Hotel__04E4BC85");

            entity.HasOne(d => d.Package).WithMany(p => p.BookingTrips)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK__BookingTr__Packa__03F0984C");

            entity.HasOne(d => d.User).WithMany(p => p.BookingTrips)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__BookingTr__UserI__5165187F");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.Feedbackid).HasName("PK__Feedback__6A4AE1FE0DF8F373");

            entity.ToTable("Feedback");

            entity.Property(e => e.Rating).HasColumnType("decimal(3, 1)");

            entity.HasOne(d => d.User).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Feedback__UserId__4E88ABD4");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.FoodId).HasName("PK__Food__856DB3EBE3C19FBB");

            entity.ToTable("Food");

            entity.Property(e => e.FoodType).HasMaxLength(50);
            entity.Property(e => e.HotelPrice).HasColumnType("money");

            entity.HasOne(d => d.Package).WithMany(p => p.Foods)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK__Food__PackageId__02FC7413");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Hotelid).HasName("PK__Hotels__46033FE7F288C522");

            entity.Property(e => e.HotelPrice).HasColumnType("money");
            entity.Property(e => e.HotelRating).HasColumnType("decimal(3, 1)");

            entity.HasOne(d => d.Package).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK__Hotels__PackageI__7F2BE32F");
        });

        modelBuilder.Entity<ItineraryDetail>(entity =>
        {
            entity.HasKey(e => e.ItineraryId).HasName("PK__Itinerar__361216C6056890E1");

            entity.Property(e => e.DayNumber)
                .HasMaxLength(20)
                .HasColumnName("Day_Number");
            entity.Property(e => e.Time).HasMaxLength(50);

            entity.HasOne(d => d.Package).WithMany(p => p.ItineraryDetails)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK__Itinerary__Packa__7C4F7684");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__Package__322035CCCBD5AFA4");

            entity.ToTable("Package");

            entity.Property(e => e.Duration).HasMaxLength(50);
            entity.Property(e => e.PackagePrice).HasColumnType("money");
            entity.Property(e => e.Place)
                .HasMaxLength(50)
                .HasColumnName("place");

            entity.HasOne(d => d.User).WithMany(p => p.Packages)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Package__UserId__797309D9");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4CC1BB78D8");

            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(40);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Idproof).HasColumnName("idproof");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
