using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Entities.Dtos
{
    public class PatientAddDto
    {
        [DisplayName("Patient No")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(1000, 9999, ErrorMessage = "{0} value must be between 1000 to 9999")]
        public virtual int No { get; set; }
        [DisplayName("Patient Insurance No")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(1000, 9999, ErrorMessage = "{0} value must be between 1000 to 9999")]
        public int InsuranceNo { get; set; }
        [DisplayName("Patient Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public virtual string? Name { get; set; }
        [DisplayName("Patient Surname")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public virtual string? Surname { get; set; }
        [DisplayName("Patient Address")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public virtual string? Address { get; set; }
    }
}
