using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CrossfitAPI.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enums.ExerciseType ExerciseType { get; set; }

        public int EquipmentId { get; set; }
        public Equipment EquimentName { get; set; }

        public int BodyPartId { get; set; }
        public BodyPart BodyPart { get; set; }

        public int MuscleGroupId { get; set; }
        public MuscleGroup TargetMuscles { get; set; }
    }
}
