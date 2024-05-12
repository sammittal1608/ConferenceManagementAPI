using ConferenceManegement.Models;
using ConferenceMeeting.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceMeeting.Repository
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly AppDBContext _context;

        public MeetingRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Meeting>> GetMeetingsByUserIdAsync(int userId)
        {
            return await _context.Meetings.Where(m => m.UserId == userId).ToListAsync();
        }

        public async Task<Meeting> GetMeetingByIdAsync(int meetingId)
        {
            return await _context.Meetings.FindAsync(meetingId);
        }

        public async Task<Meeting> AddMeetingAsync(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            await _context.SaveChangesAsync();
            return meeting;
        }
    }
}

