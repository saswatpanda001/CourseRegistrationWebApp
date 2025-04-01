using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CourseManagementWebApp.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Course Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Minimum Length=3")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Minimum Length=3")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
