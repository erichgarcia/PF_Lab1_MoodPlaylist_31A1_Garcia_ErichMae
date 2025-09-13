using MoodPlaylist.SQLite.Repository.Models;

namespace MoodPlaylist.SQLite.Services
{
    public interface IAuthService
    {
        Task<bool> InitiatePasswordResetAsync(string email);
        Task<User?> LoginAsync(string emailOrUsername, string password);
        Task<User?> RegisterAsync(string email, string username, string password);
        Task<bool> ResetPasswordAsync(string token, string newPassword);
    }
}