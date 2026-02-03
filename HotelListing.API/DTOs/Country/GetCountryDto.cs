using HotelListing.Api.DTOs.Hotel;

namespace HotelListing.Api.DTOs.Country;

public record GetCountryDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string ShortName { get; init; } = string.Empty;
    public List<GetHotelSlimDto> Hotels { get; init; } = new();
}

public record GetCountriesDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string ShortName { get; init; }
}