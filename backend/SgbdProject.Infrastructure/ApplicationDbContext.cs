using Microsoft.EntityFrameworkCore;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseSite> CourseSites { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<TravelTime> TravelTimes { get; set; }
    public DbSet<University> Universities { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //* CLASSROOM *//
        modelBuilder.Entity<Classroom>()
            .HasOne(cl => cl.Site)
            .WithMany(s => s.Classrooms)
            .HasForeignKey(cl => cl.SiteId)
            .OnDelete(DeleteBehavior.NoAction);

        //* COURSE *//
        modelBuilder.Entity<Course>()
            .HasOne(c => c.University)
            .WithMany(u => u.Courses)
            .HasForeignKey(c => c.UniversityId)
            .OnDelete(DeleteBehavior.NoAction);

        //* COURSEGROUP *//
        modelBuilder.Entity<CourseGroup>()
            .HasOne(cg => cg.Course)
            .WithMany(c => c.CourseGroups)
            .HasForeignKey(cg => cg.CourseId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CourseGroup>()
            .HasOne(cg => cg.Group)
            .WithMany(g => g.CourseGroups)
            .HasForeignKey(cg => cg.GroupId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CourseGroup>()
            .HasOne(cg => cg.AcademicYear)
            .WithMany(ay => ay.CourseGroups)
            .HasForeignKey(cg => cg.AcademicYearId)
            .OnDelete(DeleteBehavior.NoAction);

        //* COURSESITE *//
        modelBuilder.Entity<CourseSite>()
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CourseSites)
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CourseSite>()
            .HasOne(cs => cs.Site)
            .WithMany(s => s.CourseSites)
            .HasForeignKey(cs => cs.SiteId)
            .OnDelete(DeleteBehavior.NoAction);

        //* GROUP *//
        modelBuilder.Entity<Group>()
            .HasOne(g => g.MainSite)
            .WithMany()
            .HasForeignKey(g => g.MainSiteId)
            .OnDelete(DeleteBehavior.NoAction);

        //* HOLIDAY *//
        modelBuilder.Entity<Holiday>()
            .HasOne(h => h.Site)
            .WithMany(s => s.Holidays)
            .HasForeignKey(h => h.SiteId)
            .OnDelete(DeleteBehavior.NoAction);

        //* SCHEDULE *//
        modelBuilder.Entity<Schedule>()
            .HasOne(sc => sc.Course)
            .WithMany(c => c.Schedules)
            .HasForeignKey(sc => sc.CourseId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Schedule>()
            .HasOne(sc => sc.Group)
            .WithMany(g => g.Schedules)
            .HasForeignKey(sc => sc.GroupId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Schedule>()
            .HasOne(sc => sc.Classroom)
            .WithMany(cl => cl.Schedules)
            .HasForeignKey(sc => sc.ClassroomId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Schedule>()
            .HasOne(sc => sc.AcademicYear)
            .WithMany(ay => ay.Schedules)
            .HasForeignKey(sc => sc.AcademicYearId)
            .OnDelete(DeleteBehavior.NoAction);

        //* SITE *//
        modelBuilder.Entity<Site>()
            .HasOne(s => s.University)
            .WithMany(u => u.Sites)
            .HasForeignKey(s => s.UniversityId)
            .OnDelete(DeleteBehavior.NoAction);

        //* SITESCHEDULE *//
        modelBuilder.Entity<SiteSchedule>()
            .HasOne(ss => ss.Site)
            .WithMany(s => s.SiteSchedules)
            .HasForeignKey(ss => ss.SiteId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<University>()
            .HasMany(u => u.Courses)
            .WithOne(c => c.University)
            .HasForeignKey(c => c.UniversityId)
            .OnDelete(DeleteBehavior.NoAction);

        //* TRAVELTIME *//
        modelBuilder.Entity<TravelTime>()
            .HasOne(tt => tt.FromSite)
            .WithMany()
            .HasForeignKey(tt => tt.FromSiteId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<TravelTime>()
            .HasOne(tt => tt.ToSite)
            .WithMany()
            .HasForeignKey(tt => tt.ToSiteId)
            .OnDelete(DeleteBehavior.NoAction);

        //* UNIVERSITY *//
        modelBuilder.Entity<University>()
            .HasMany(u => u.Groups)
            .WithOne(g => g.University)
            .HasForeignKey(g => g.UniversityId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<University>()
            .HasMany(u => u.Sites)
            .WithOne(s => s.University)
            .HasForeignKey(s => s.UniversityId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}