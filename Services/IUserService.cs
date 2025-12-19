using LibraryManagement_BackendAPI.Dtos;

namespace LibraryManagement_BackendAPI.Services
{
    public interface IUserService
    {
        Task RegisterAsync(RegisterUserDto dto);
        Task<String?> LoginAsync(LoginUserDto dto);
    }
}
