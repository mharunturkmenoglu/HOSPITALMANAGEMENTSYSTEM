using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Entities.Dtos
{
    public class DoctorUpdateDto
    {
        [DisplayName("Doctor No")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(1000, 9999, ErrorMessage = "{0} value must be between 1000 to 9999")]
        public int No { get; set; }
        [DisplayName("Doctor Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public string? Name { get; set; }
        [DisplayName("Doctor Surname")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public string? Surname { get; set; }
        [DisplayName("Doctor Address")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} field must be at least {1} characters")]
        [MinLength(2, ErrorMessage = "{0} field must be maximum {1} characters")]
        public string? Address { get; set; }
    }
}
