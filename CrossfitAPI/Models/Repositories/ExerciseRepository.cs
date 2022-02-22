using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrossfitAPI.Models.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ExerciseContext _context;

        public ExerciseRepository(ExerciseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Exercise>> Get()
        {
            return await _context.Exercises.ToListAsync();
        }

        public async Task<Exercise> Get(int id)
        {
            return await _context.Exercises.FindAsync(id);
        }

        public async Task<Exercise> Create(Exercise exercise)
        {
            _context.Add(exercise);
            await _context.SaveChangesAsync();

            return exercise;
        }

        public async Task Delete(int id)
        {
            var exerciseToDelete = await _context.Exercises.FindAsync(id);
            _context.Exercises.Remove(exerciseToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Exercise exercise)
        {
            _context.Entry(exercise).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
