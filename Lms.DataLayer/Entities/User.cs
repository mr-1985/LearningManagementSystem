using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities.News;

namespace Lms.DataLayer.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string NationalCode { get; set; }

        [MaxLength(50)]
        public string ShomarehShenasnameh { get; set; }

        [MaxLength(50)]
        public string Tell { get; set; }

        [MaxLength(50)]
        public string SerialeShenasnameh { get; set; }

        public DateTime BirthDate { get; set; }

        public int CityId { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        [MaxLength(200)]
        public string Mobile { get; set; }

        [MaxLength(200)]
        public string ActivationCode { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(200)]
        public string UserAvatar { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public int? EducationId { get; set; }
        public int? LocationStatusId { get; set; }
        public int? Sex { get; set; }

        [MaxLength(50)]
        public string MahaleSodooreShenasnameh { get; set; }

        [MaxLength(50)]
        public string CodePosti { get; set; }

        [MaxLength(50)]
        public string FatherName { get; set; }

        public int? MaritalStatus { get; set; }
        public int? SabegheKar { get; set; }

        [MaxLength(50)]
        public string CodeBimeh { get; set; }

        public int? SalaryPerMonth { get; set; }
        public int? WomanSalary { get; set; }

        [MaxLength(50)]
        public string Job { get; set; }

        [MaxLength(500)]
        public string JobAddress { get; set; }

        [MaxLength(50)]
        public string JobTell { get; set; }

        [MaxLength(50)]
        public string RegionalMunicipality { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<Wallet> Wallets { get; set; }
        public virtual List<Course> Courses { get; set; }
        public List<Page> Pages { get; set; }
        public List<UserCourse> UserCourses { get; set; }
        public List<ExamStudent> ExamStudents { get; set; }
        public List<QuestionHistory> QuestionHistories { get; set; }
        public List<MultipleQuestion> MultipleQuestions { get; set; }
        public List<UserScore> UserScores { get; set; }
        public List<CourseComment> CourseComments { get; set; }
        public List<PageComment> PageComments { get; set; }
        public virtual List<Order> Orders { get; set; }
        public List<CourseVote> CourseVotes { get; set; }
        public List<UserDiscountCode> UserDiscountCodes { get; set; }

    }
}
