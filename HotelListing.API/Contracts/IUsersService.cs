using HotelListing.Api.Results;
using HotelListing.API.DTOs.Auth;

namespace HotelListing.Api.Contracts;

public interface IUsersService
{
    Task<Result<string>> LoginAsync(LoginUserDto dto);
    Task<Result<RegisteredUserDto>> RegisterAsync(RegisterUserDto registerUserDto);
}