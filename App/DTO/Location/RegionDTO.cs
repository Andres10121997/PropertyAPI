namespace PropertyAPI.App.DTO.Location
{
    public record RegionDTO
    {
        public required string Name { get; init; }
        public required string Abbreviation { get; init; }
        public required string Ordinal { get; init; }
    }
}