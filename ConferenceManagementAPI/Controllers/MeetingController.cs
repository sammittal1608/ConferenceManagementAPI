using ConferenceManegement.Models;
using ConferenceMeeting.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagementAPI.Controllers
{
    [ApiController]
    [Route("api/meetings")]
    [Authorize]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService meetingService;
        public MeetingController(IMeetingService _meetingService)
        {
            meetingService = _meetingService;
        }
        [HttpPost]
        public async IActionResult CreateMeeting([FromBody] CreateMeetingRequest createMeetingRequest)
        {
            try
            {

                MeetingResponse result =await meetingService.AddMeetingAsync(createMeetingRequest);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Create Meeting is failed");
            }
        }

        [HttpGet]
        public IActionResult GetMeetings()
        {
            return null;
        }

        [HttpGet("{meetingId}")]
        public IActionResult GetMeeting(int meetingId)
        {
            return null;
        }

        [HttpPut("{meetingId}")]
        public IActionResult UpdateMeeting(int meetingId, [FromBody] Meeting model)
        {
            return null;
        }

        [HttpDelete("{meetingId}")]
        public IActionResult DeleteMeeting(int meetingId)
        {
            return null;
        }
    }
}
