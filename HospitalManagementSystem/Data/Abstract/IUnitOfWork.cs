namespace HospitalManagementSystem.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAppointmentRepository Appointments { get; }
        IDoctorRepository Doctors { get; }
        IPatientRepository Patients { get; }
        int Save();
    }
}
