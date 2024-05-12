using ConferenceManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceMeeting.Repository.Interfaces
{
    public interface IMeetingRepository
    {
        Task<List<Meeting>> GetMeetingsByUserIdAsync(int userId);
        Task<Meeting> GetMeetingByIdAsync(int meetingId);
        Task<Meeting> AddMeetingAsync(Meeting meeting);
    }

}
