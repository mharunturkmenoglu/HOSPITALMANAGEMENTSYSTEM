using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Data.Concrete.EntityFramework.Contexts;
using HospitalManagementSystem.Data.Concrete.EntityFramework.Repositories;

namespace HospitalManagementSystem.Data.Concrete.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private EfAppointmentRepository _appointmentRepository;
        private EfDoctorRepository _doctorRepository;
        private EfPatientRepository _patientRepository;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IAppointmentRepository Appointments => _appointmentRepository ?? new EfAppointmentRepository(_context);

        public IDoctorRepository Doctors => _doctorRepository ?? new EfDoctorRepository(_context);

        public IPatientRepository Patients => _patientRepository ?? new EfPatientRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
