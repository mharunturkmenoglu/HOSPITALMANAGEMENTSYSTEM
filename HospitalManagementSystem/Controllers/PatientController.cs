using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("patient")]
        public async Task<ActionResult> GetPatient()
        {
            var patientList = await _patientService.GetAllPatients();
            return Ok(patientList);
        }

        [HttpGet("patient/{id:int}")]
        public async Task<ActionResult> GetPatientById(int id)
        {
            var patient = await _patientService.GetPatient(id);
            return Ok(patient);
        }

        [HttpPost("patient")]
        public async Task<ActionResult> AddPatient(PatientAddDto patientAddDto)
        {
            await _patientService.AddPatient(patientAddDto);
            return Ok();
        }

        [HttpPut("patient/{id:int}")]
        public async Task<ActionResult> UpdatePatient(PatientUpdateDto patientUpdateDto, int id)
        {
            await _patientService.UpdatePatient(patientUpdateDto, id);
            return Ok();
        }

        [HttpDelete("patient/{id:int}")]
        public async Task<ActionResult> DeletePatient(int id)
        {
            await _patientService.RemovePatient(id);
            return Ok();
        }
    }
}
