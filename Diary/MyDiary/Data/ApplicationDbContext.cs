using Microsoft.EntityFrameworkCore;
using MyDiary.Models;

namespace MyDiary.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        // Four Steps to add a Table
        // 1.Create a Model Class
        // 2.Add DbSet
        // 3.add-migration AddEntryTable
        //update-Database
    }
}
