using AutoMapper;
using ConferenceManegement.Models;
using ConferenceMeeting.Repository.Interfaces;
using ConferenceMeeting.Services.Interfaces;

namespace ConferenceMeeting.Services
{
    public class MeetingService:IMeetingService
    {
        private readonly IMeetingRepository _meetingRepository;
        private readonly IMapper _mapper;

        public MeetingService(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<MeetingResponse> AddMeetingAsync(CreateMeetingRequest meeting)
        {
            var meetingId = Guid.NewGuid().ToString();

            var meetingEntity = _mapper.Map<Meeting>(meeting);

            meetingEntity.MeetingId = meetingId;

            await _meetingRepository.AddMeetingAsync(meetingEntity);

            var meetingResponse = _mapper.Map<MeetingResponse>(meetingEntity);

            return meetingResponse;
        }

        public async Task<MeetingResponse> GetMeetingByIdAsync(int meetingId)
        {
            var meetingEntity = await _meetingRepository.GetMeetingByIdAsync(meetingId);

            var meetingResponse = _mapper.Map<MeetingResponse>(meetingEntity);

            return meetingResponse;
        }

        public async Task<List<MeetingResponse>> GetMeetingsByUserIdAsync(int userId)
        {
            var meetingEntities = await _meetingRepository.GetMeetingsByUserIdAsync(userId);

            var meetingResponses = _mapper.Map<List<MeetingResponse>>(meetingEntities);

            return meetingResponses;
        }

      
    }
}
