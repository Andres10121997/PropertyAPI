using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyAPI.App.DTO.Property
{
    public record PropertyDTO
    {
        [
            Display(
                AutoGenerateField = false,
                AutoGenerateFilter = false,
                Description = "",
                GroupName = nameof(PropertyDTO),
                Name = "Área total",
                Order = 1,
                Prompt = "",
                ShortName = ""
            ),
            Required
        ]
        public required float TotalArea { get; init; }

        [
            Display(
                AutoGenerateField = false,
                AutoGenerateFilter = false,
                Description = "",
                GroupName = nameof(PropertyDTO),
                Name = "Área usable",
                Order = 2,
                Prompt = "",
                ShortName = ""
            ),
            Required
        ]
        public required float UsableArea { get; init; }
        public required DateOnly CreationDate { get; init; }
        public required TimeOnly CreationTime { get; init; }
    }
}