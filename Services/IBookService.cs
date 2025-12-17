using LibraryManagement_BackendAPI.Dtos;
using LibraryManagement_BackendAPI.Models;

namespace LibraryManagement_BackendAPI.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int  id);
        Task<Book> CreateAsync(CreateBookDto dto);
        Task<bool> UpdateAsync(int id, UpdateBookDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
