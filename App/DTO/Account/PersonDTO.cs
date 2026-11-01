using System;

namespace PropertyAPI.App.DTO.Account
{
    public record PersonDTO
    {
        public required string FirstName { get; init; }
        public string? MiddleName { get; init; }
        public required string FirstLastName { get; init; }
        public string? SecondLastName { get; init; }
        public required DateOnly Birthday { get; init; }
    }
}