using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab.Models;
using lab.Services;

namespace lab.Data;

public class ApplicationDbContext : IdentityDbContext
{
  public DbSet<Student>? Students { get; set; }
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);

    List<Student> students = StudentsService.GetStudents().Result;
    builder.Entity<Student>()
      .HasData(students);
  }

}
