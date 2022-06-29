namespace HospitalManagementSystem.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IAppointmentRepository Appointments { get; }
        IDoctorRepository Doctors { get; }
        IPatientRepository Patients { get; }
        Task<int> SaveAsync();
    }
}
