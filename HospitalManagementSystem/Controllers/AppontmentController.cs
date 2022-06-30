using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [ApiController]
    public class AppontmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppontmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("appointment")]
        public async Task<ActionResult> GetAppointment()
        {
            var appointmentList = await _appointmentService.GetAllAppointments();
            return Ok(appointmentList);
        }

        [HttpGet("appointment/{id:int}")]
        public async Task<ActionResult> GetAppointmentById(int id)
        {
            var appointment = await _appointmentService.GetAppointment(id);
            return Ok(appointment);
        }

        [HttpPost("appointment")]
        public async Task<ActionResult> AddAppointment(AppointmentAddDto appointmentAddDto)
        {
            await _appointmentService.AddAppointment(appointmentAddDto);
            return Ok();
        }

        [HttpPut("appointment/{id:int}")]
        public async Task<ActionResult> UpdateAppointment(AppointmentUpdateDto appointmentUpdateDto, int id)
        {
            await _appointmentService.UpdateAppointment(appointmentUpdateDto, id);
            return Ok();
        }

        [HttpDelete("appointment/{id:int}")]
        public async Task<ActionResult> DeleteAppointment(int id)
        {
            await _appointmentService.RemoveAppointment(id);
            return Ok();
        }
    }
}
