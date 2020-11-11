using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF
{
    #region CourseMetadata
    public class CourseMetadata
    {
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "* Course Name is required")]
        [StringLength(50, ErrorMessage = "* Course Name cannot be longer than 50 characters")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "* Course Description is required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "* Credit Hours is required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [UIHint("MultilineText")]
        [StringLength(250, ErrorMessage = "* Curriculum cannot be longer than 250 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string Curriculum { get; set; }

        [UIHint("MultilineText")]
        [StringLength(500, ErrorMessage = "* Notes cannot be longer than 500 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string Notes { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }
    #endregion

    #region EnrollmentMetadata
    public class EnrollmentMetadata
    {
        [Display(Name = "Enrollment ID")]
        public int EnrollmentId { get; set; }

        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Display(Name = "Student Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "* Enrollment Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {

    }
    #endregion

    #region ScheduledClassMetadata
    public class ScheduledClassMetadata
    {
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "* Start Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "* End Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "* Instructor Name is required")]
        [StringLength(40, ErrorMessage = "* Instructor Name cannot be longer than 40 characters")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "* Location is required")]
        [StringLength(20, ErrorMessage = "* Location cannot be longer than 20 characters")]
        public string Location { get; set; }

        [Display(Name = "Scheduled Class Status ID")]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {

    }
    #endregion

    #region ScheduledClassStatusMetadata
    public class ScheduledClassStatusMetadata
    {
        [Display(Name = "Scheduled Class Status ID")]
        public int SCSID { get; set; }

        [Display(Name = "Scheduled Class Status Name")]
        [Required(ErrorMessage = "* Scheduled Class Status Name is required")]
        [StringLength(50, ErrorMessage = "* Scheduled Class Status Name cannot be longer than 50 characters")]
        public string SCSName { get; set; }
    }

    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus
    {

    }

    #endregion

    #region StudentMetadata


    public class StudentMetadata
    {
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "* First Name is required")]
        [StringLength(20, ErrorMessage = "* First Name cannot be longer than 20 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "* Last Name is required")]
        [StringLength(20, ErrorMessage = "* Last Name cannot be longer than 20 characters")]
        public string LastName { get; set; }


        [StringLength(15, ErrorMessage = "* Major cannot be longer than 15 characters")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "* Address cannot be longer than 50 characters")]
        public string Address { get; set; }

        [StringLength(25, ErrorMessage = "* City cannot be longer than 25 characters")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "* State cannot be longer than 2 characters")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(10, ErrorMessage = "* Zip Code cannot be longer than 10 characters")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "* Phone cannot be longer than 13 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "* Email is required")]
        [StringLength(60, ErrorMessage = "* Email cannot be longer than 60 characters")]
        public string Email { get; set; }

        [Display(Name = "Photo Url")]
        [StringLength(100, ErrorMessage = "* Photo Url cannot be longer than 100 characters")]
        public string PhotoUrl { get; set; }

        [Display(Name = "Student Status ID")]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Student Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
    }
    #endregion

    #region StudentStatusMetadata

    public class StudentStatusMetadata
    {
        [Display(Name = "Student Status ID")]
        public int SSID { get; set; }

        [Display(Name = "Student Status Name")]
        [Required(ErrorMessage = "* Student Status Name is required")]
        [StringLength(30, ErrorMessage = "* Student Status Name cannot be longer than 30 characters")]
        public string SSName { get; set; }

        [UIHint("MultilineText")]
        [Display(Name = "Student Status Description")]
        [StringLength(250, ErrorMessage = "* Student Status Description cannot be longer than 250 characters")]
        public string SSDescription { get; set; }
    }

    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
    {

    }

    #endregion
}
