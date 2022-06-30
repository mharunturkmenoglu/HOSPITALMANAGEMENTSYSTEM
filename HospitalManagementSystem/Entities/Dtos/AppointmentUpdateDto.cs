using HospitalManagementSystem.Entities.Concrete;

namespace HospitalManagementSystem.Entities.Dtos
{
    public class AppointmentUpdateDto
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
