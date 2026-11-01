namespace PropertyAPI.App.DTO.Company
{
    public record CompanyDTO
    {
        public ulong Id { get; init; }
        public required string Name { get; init; }
        public required string TradeName { get; init; }
    }
}