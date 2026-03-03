using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VolunteersApp.Models;

public partial class DbVolunteersContext : DbContext
{
    public DbVolunteersContext()
    {
    }

    public DbVolunteersContext(DbContextOptions<DbVolunteersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventStatus> EventStatuses { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<RegistrationStatus> RegistrationStatuses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VolunteerRegistration> VolunteerRegistrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_volunteers;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.HasIndex(e => e.CategoryName, "Uq_categories_category_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateEvent).HasColumnName("date_event");
            entity.Property(e => e.EventName).HasColumnName("event_name");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdPlace).HasColumnName("id_place");
            entity.Property(e => e.IdStatusEvent).HasColumnName("id_status_event");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.VolunteersNeed).HasColumnName("volunteers_need");

            entity.HasOne(d => d.Category).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_events_to_categories");

            entity.HasOne(d => d.Place).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdPlace)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_events_to_places");

            entity.HasOne(d => d.EventStatus).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdStatusEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_events_to_event_statuses");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_events_to_users");
        });

        modelBuilder.Entity<EventStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("event_statuses_pkey");

            entity.ToTable("event_statuses");

            entity.HasIndex(e => e.EventStatusName, "uq_event_statuses_event_status_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventStatusName).HasColumnName("event_status_name");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("places_pkey");

            entity.ToTable("places");

            entity.HasIndex(e => e.PlaceName, "uq_places_place_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlaceName).HasColumnName("place_name");
        });

        modelBuilder.Entity<RegistrationStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("registration_statuses_pkey");

            entity.ToTable("registration_statuses");

            entity.HasIndex(e => e.RegistrStatusName, "uq_registration_statuses_registr_status_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RegistrStatusName).HasColumnName("registr_status_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "uq_roles_role_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Fio).HasColumnName("FIO");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_to_roles");
        });

        modelBuilder.Entity<VolunteerRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName(" volunteer_registration_pkey");

            entity.ToTable(" volunteer_registration");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRegistr).HasColumnName("date_registr");
            entity.Property(e => e.IdEvent).HasColumnName("id_event");
            entity.Property(e => e.IdRegistrStatus).HasColumnName("id_registr_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.Event).WithMany(p => p.VolunteerRegistrations)
                .HasForeignKey(d => d.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_volunt_registr_to_event");

            entity.HasOne(d => d.RegistrationStatus).WithMany(p => p.VolunteerRegistrations)
                .HasForeignKey(d => d.IdRegistrStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_volunt_registr_to_registr_statuses");

            entity.HasOne(d => d.User).WithMany(p => p.VolunteerRegistrations)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_volunt_registr_to_users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
