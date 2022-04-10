using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Lms.DataLayer.Entities.News;
using Microsoft.EntityFrameworkCore;

namespace Lms.DataLayer.Context
{
    public class LmsContext:DbContext
    {
        public LmsContext(DbContextOptions<LmsContext> options) : base(options)
        {

        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatus { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<LocationStatus> LocationStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<VirtualClass> VirtualClasses { get; set; }
        public DbSet<VirtualClassFile> VirtualClassFiles { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseVote> CourseVotes { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }


        #region Exam

        public DbSet<UserScore> UserScores { get; set; }
        public DbSet<QuestionLevel> QuestionLevels { get; set; }
        public DbSet<MultipleQuestion> MultipleQuestions { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionHistory> QuestionHistories { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamStudent> ExamStudents { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }

        #endregion
        
        #region News

        public DbSet<Page> Pages { get; set; }
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<PageComment> PageComments { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCourse>()
                .HasOne(u => u.Course)
                .WithMany(u => u.UserCourses)
                .HasForeignKey(u => u.CourseId);

            modelBuilder.Entity<Course>()
                .HasOne(u => u.CourseLevel)
                .WithMany(u => u.Courses)
                .HasForeignKey(u => u.LevelId);

            modelBuilder.Entity<Course>()
                .HasOne(u => u.CourseStatus)
                .WithMany(u => u.Courses)
                .HasForeignKey(u => u.StatusId);

            modelBuilder.Entity<Course>()
                .HasOne(u => u.CourseGroup)
                .WithMany(u => u.Courses)
                .HasForeignKey(u => u.SubGroup);

            modelBuilder.Entity<Course>()
                .HasOne(u => u.CourseGroup)
                .WithMany(u => u.Courses)
                .HasForeignKey(u => u.GroupId);

            modelBuilder.Entity<Wallet>()
                .HasOne(u => u.WalletType)
                .WithMany(u => u.Wallets)
                .HasForeignKey(u => u.TypeId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(u => u.Order)
                .WithMany(u => u.OrderDetails)
                .HasForeignKey(u => u.OrderId);

            modelBuilder.Entity<Page>()
                .HasOne(u => u.User)
                .WithMany(u => u.Pages)
                .HasForeignKey(u => u.AuthorId);

            modelBuilder.Entity<Wallet>().HasKey(w => w.WalletId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
