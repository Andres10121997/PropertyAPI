using System;

namespace PropertyAPI.App.DTO.Property
{
    public record PropertyDTO
    {
        public required float TotalArea { get; init; }
        public required float UsableArea { get; init; }
        public required DateOnly CreationDate { get; init; }
        public required TimeOnly CreationTime { get; init; }
    }
}