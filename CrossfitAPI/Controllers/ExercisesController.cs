using CrossfitAPI.Models;
using CrossfitAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrossfitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExercisesController(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Exercise>> GetExercises()
        {
            return await _exerciseRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Exercise>> GetExercise([ModelBinder] int id)
        {
            return await _exerciseRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Exercise>> PostExercise([FromBody] Exercise exercise)
        {
            var newExercise = await _exerciseRepository.Create(exercise);
            return CreatedAtAction(nameof(GetExercises), new { id = newExercise }, newExercise);
        }

        [HttpPut]
        public async Task<ActionResult> PutExercise(int id, [FromBody] Exercise exercise)
        {
            if (id != exercise.Id)
            {
                return BadRequest();
            }

            await _exerciseRepository.Update(exercise);

            // 201 OK response
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var exerciseToDelete = await _exerciseRepository.Get(id);
            if (exerciseToDelete == null)
                return NotFound();

            await _exerciseRepository.Delete(exerciseToDelete.Id);
            return NoContent();
        }
    }
}
