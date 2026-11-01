namespace PropertyAPI.App.DTO.Location
{
    public record CountryDTO
    {
        public required string Name { get; init; }
        public required string Iso { get; init; }
        public required string Iso3 { get; init; }
        public required int Numcode { get; init; }
        public required int PhoneCode { get; init; }
    }
}