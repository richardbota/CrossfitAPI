using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CrossfitAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExerciseType
    {
        WeightLifting,
        KettleBell,
        BodyWeight,
        Endurance
    }
}
