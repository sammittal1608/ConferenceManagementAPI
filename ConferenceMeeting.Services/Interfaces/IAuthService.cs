using ConferenceManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceMeeting.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<User> GetUserByUsernameAsync(string username);
        Task<UserResponse> AddUserAsync(User user);
    }

}
