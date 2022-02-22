using Microsoft.EntityFrameworkCore;

namespace CrossfitAPI.Models
{
    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Exercise> Exercises { get; set; }
        //public DbSet<Equipment> Equipments { get; set; }
        //public DbSet<MuscleGroup> MuscleGroups { get; set; }
    }
}
