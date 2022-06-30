using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctor)
        {
            this._doctorService = doctor;
        }

        [HttpGet("doctor")]
        public async Task<ActionResult> GetDoctor()
        {
            var doctorList = await _doctorService.GetAllDoctors();
            return Ok(doctorList);
        }

        [HttpGet("doctor/{id:int}")]
        public async Task<ActionResult> GetDoctorById(int id)
        {
            var doctor = await _doctorService.GetDoctor(id);
            return Ok(doctor);
        }

        [HttpPost("doctor")]
        public async Task<ActionResult> AddDoctor(DoctorAddDto doctorAddDto)
        {
            await _doctorService.AddDoctor(doctorAddDto);
            return Ok();
        }

        [HttpPut("doctor/{id:int}")]
        public async Task<ActionResult> UpdateDoctor(DoctorUpdateDto doctorUpdateDto, int id)
        {
            await _doctorService.UpdateDoctor(doctorUpdateDto, id);
            return Ok();
        }

        [HttpDelete("doctor/{id:int}")]
        public async Task<ActionResult> DeleteDoctor(int id)
        {
            await _doctorService.RemoveDoctor(id);
            return Ok();
        }
    }
}
