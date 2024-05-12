using ConferenceManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceMeeting.Services.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingResponse>> GetMeetingsByUserIdAsync(int userId);
        Task<MeetingResponse> GetMeetingByIdAsync(int meetingId);
        Task<MeetingResponse> AddMeetingAsync(CreateMeetingRequest meeting);

    }
}
