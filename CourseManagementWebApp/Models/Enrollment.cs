using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CourseManagementWebApp.Models
{
    public partial class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "User ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Course ID is required.")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Enrollment Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
