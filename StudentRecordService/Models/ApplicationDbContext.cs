using Microsoft.EntityFrameworkCore;

namespace StudentRecordService.Models;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public DbSet<StudentRecordServiceModel> studentRecord { get; set; }
}