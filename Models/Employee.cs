using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HRApplication.Models
{
    public class Employee
    {
        [Required]
        [StringLength(20,MinimumLength =3)]
        public  string Ename { get; set; }

        public string Edepartment { get; set; }

        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        [Required(ErrorMessage ="JOb title is missing")]
        [DataType(DataType.Text)]
        public string JobTitle { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
