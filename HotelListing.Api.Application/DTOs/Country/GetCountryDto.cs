using HotelListing.Api.Application.DTOs.Hotel;
using HotelListing.Api.Common.Models.Paging;

namespace HotelListing.Api.Application.DTOs.Country;

public record GetCountryDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string ShortName { get; init; } = string.Empty;
    public List<GetHotelSlimDto> Hotels { get; init; } = new();
}

public class GetCountryHotelsDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PagedResult<GetHotelSlimDto> Hotels { get; set; } = new();
}

public record GetCountriesDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string ShortName { get; init; }
}