using LibraryManagement_BackendAPI.Data;
using LibraryManagement_BackendAPI.Dtos;
using LibraryManagement_BackendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_BackendAPI.Services
{
    public class BookService : IBookService
    {
        public readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }


        public async Task<Book> CreateAsync(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Author = dto.Author,
                Description = dto.Description
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> UpdateAsync(int id, UpdateBookDto dto)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return false;

            book.Title = dto.Title;
            book.Author = dto.Author;
            book.Description = dto.Description;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if(book == null) return false;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
