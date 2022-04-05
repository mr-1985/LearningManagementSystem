using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Convertors;
using Lms.Core.Generators;
using Lms.Core.Security;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Lms.Core.Services
{
    public class CourseService : ICourseService
    {
        private LmsContext _context;
        private IHostingEnvironment _environment;

        public CourseService(LmsContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public void DeleteCourse(int courseId)
        {
            var course = GetCourseById(courseId);
            course.IsDelete = true;
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.UpdateDate = DateTime.Now;

            if (imgCourse != null && imgCourse.IsImage())
            {
                if (course.CourseImage != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/thumb", course.CourseImage);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                course.CourseImage = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/thumb", course.CourseImage);

                imgResizer.Image_resize(imagePath, thumbPath, 250);
            }

            if (courseDemo != null)
            {
                if (course.DemoFileName != null)
                {
                    string deleteDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/demoes", course.DemoFileName);
                    if (File.Exists(deleteDemoPath))
                    {
                        File.Delete(deleteDemoPath);
                    }
                }
                course.DemoFileName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }

            _context.Courses.Update(course);
            _context.SaveChanges();
        }


        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }

        public Tuple<List<CourseForAdminListPageViewModel>, CourseForAdminViewModel> GetCourses(int PageId = 1, int take = 5, string filter = "")
        {
            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.Title.Contains(filter) || c.Group.GroupTitle.Contains(filter));
            }

            int takeDate = take;
            int skip = (PageId - 1) * takeDate;

            CourseForAdminViewModel list = new CourseForAdminViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.Courses = result.OrderByDescending(c => c.CreateDate).Skip(skip).Take(takeDate).ToList();
            list.UserCounts = _context.Courses.Count();

            var query = result.Where(g => g.IsDelete == false).
                Include(g => g.CourseGroup).
                Select(c => new CourseForAdminListPageViewModel()
                {
                    groupTitle = c.Group.GroupTitle,
                    CourseId = c.Id,
                    CourseImage = c.CourseImage,
                    CreateDate = c.CreateDate,
                    IsActive = c.IsActive,
                    Title = c.Title
                }).Skip(skip).Take(takeDate).ToList();

            return Tuple.Create(query, list);
        }

        public List<SelectListItem> GetTeachers()
        {
            return _context.UserRoles.Where(r => r.RoleId == 3)
                .Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Value = u.UserId.ToString(),
                    Text = u.User.FirstName + " " + u.User.LastName
                }).ToList();
        }

        //public Tuple<List<CourseForUserListPageViewModel>, MyCourseViewModel> GetCoursesUser(int userId,int PageId = 1, int take = 5, string filter = "" )
        //{
        //    IQueryable<UserCourse> result = _context.UserCourses;

        //    int takeDate = take;
        //    int skip = (PageId - 1) * takeDate;

        //    MyCourseViewModel list = new MyCourseViewModel();
        //    list.CurrentPage = PageId;
        //    list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
        //    list.UserCourses = result.Skip(skip).Take(takeDate).ToList();
        //    list.UserCounts = _context.UserCourses.Count();

        //    //CourseForAdminViewModel list = new CourseForAdminViewModel();
        //    //list.CurrentPage = PageId;
        //    //list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
        //    //list.Courses = result.OrderByDescending(c => c.CreateDate).Skip(skip).Take(takeDate).ToList();
        //    //list.UserCounts = _context.Courses.Count();

        //    var query = _context.UserCourses.
        //        Where(u => u.UserId == userId && u.IsDelete == false).
        //        Include(c => c.Course).
        //        Include(c => c.User)
        //        .Select(c => new CourseForUserListPageViewModel()
        //        {
        //            CourseId = c.CourseId,
        //            CourseImage = c.Course.CourseImage,
        //            CreateDate = c.Course.CreateDate,
        //            IsActive = c.Course.IsActive,
        //            TeacherName = c.Course.TeacherId.ToString(),
        //            Title = c.Course.Title
        //        }).
        //        ToList();



        //    return Tuple.Create(query, list);
        //}

        public MyCourseViewModel GetCoursesUsers(int userId, int PageId = 1, int take = 5, string filter = "")
        {
            var result = _context.UserCourses.Where(u => u.UserId == userId && u.IsDelete == false)
                .Include(u => u.Course).Include(u => u.User).Select(u => new CourseForUserListPageViewModel()
                {
                    Title = u.Course.Title,
                    CourseImage = u.Course.CourseImage,
                    CourseId = u.CourseId,
                    CreateDate = u.Course.CreateDate,
                    IsActive = u.Course.IsActive
                });

            if (!string.IsNullOrEmpty(filter))
            {
                result = _context.UserCourses.Where(u => u.UserId == userId && u.IsDelete == false && u.Course.Title.Contains(filter))
                    .Include(u => u.Course).Include(u => u.User).Select(u => new CourseForUserListPageViewModel()
                    {
                        Title = u.Course.Title,
                        CourseImage = u.Course.CourseImage,
                        CourseId = u.CourseId,
                        CreateDate = u.Course.CreateDate,
                        IsActive = u.Course.IsActive
                    });
            }

            int takeDate = take;
            int skip = (PageId - 1) * takeDate;
            MyCourseViewModel list = new MyCourseViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.CourseForUserListPage = result.OrderByDescending(u => u.CreateDate).Skip(skip).Take(takeDate).ToList();
            list.UserCounts = result.Count();

            return list;
        }

        public EditCourseViewModel GetCourseByIdForEdit(int courseId)
        {
            return _context.Courses.Where(u => u.Id == courseId).Select(u => new EditCourseViewModel()
            {

                CourseImage = u.CourseImage,
                AboutCourse = u.AboutCourse,
                CourseId = u.Id,
                IsActive = u.IsActive,
                Title = u.Title,


            }).Single();
        }
        public void EditCourseFromAdmin(EditCourseViewModel editCourse)
        {
            var course = GetCourseById(editCourse.CourseId);
            course.AboutCourse = editCourse.AboutCourse;
            course.IsActive = editCourse.IsActive;
            course.IsDelete = false;
            course.Title = editCourse.Title;



            if (editCourse.CourseFile != null)
            {
                string imagePath = "";
                if (editCourse.CourseImage != "CourseDefault.jpg")
                {
                    //------Delete User Image --------//
                    imagePath = Path.Combine(_environment.WebRootPath, "CoursesPic", editCourse.CourseImage);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                //-------Upload New User Image --------//
                editCourse.CourseImage =
                    GeneratorName.GenrateUniqeCode() + Path.GetExtension(editCourse.CourseFile.FileName);
                imagePath = Path.Combine(_environment.WebRootPath, "CoursesPic", editCourse.CourseImage);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editCourse.CourseFile.CopyTo(stream);
                }
            }

            course.CourseImage = editCourse.CourseImage;
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public InformationCourseViewModel GetCourseInformation(int CourseId)
        {
            var course = GetCourseById(CourseId);
            InformationCourseViewModel information = new InformationCourseViewModel();
            information.CourseImage = course.CourseImage;
            information.AboutCourse = course.AboutCourse;
            information.Title = course.Title;
            information.CreateDate = course.CreateDate;
            information.Code = CourseId.ToString();
            return information;
        }

        public GetTeacherViewModel getTeacherList(int courseId)
        {
            var teacherId = _context.Courses.Single(c => c.Id == courseId).TeacherId;

            return _context.Users.Where(u => u.UserId == teacherId).Select(u => new GetTeacherViewModel()
            {
                UserId = u.UserId,
                FirstName = u.FirstName,
                UserName = u.UserName,
                LastName = u.LastName,
                Mobile = u.Mobile,
                UserAvatar = u.UserAvatar
            }).Single();
        }

        //public List<GetTeacherViewModel> getTeacherListNotSelectedInClass(int CourseId)
        //{
        //    var query = from u in _context.Users
        //                join ui in _context.UserRoles
        //                    on u.UserId equals ui.UserId
        //                where (ui.Role.RoleId == 3)
        //                select (new GetTeacherViewModel()
        //                {
        //                    FirstName = u.FirstName,
        //                    LastName = u.LastName,
        //                    Mobile = u.Mobile,
        //                    UserName = u.UserName,
        //                    UserAvatar = u.UserAvatar,
        //                    UserId = u.UserId,
        //                    //TeacherCourseId = 0

        //                });

        //    return query.ToList();
        //}

        public int AddTeacherToClass(int teacherId, int courseId)
        {
            var teacheIsEist = _context.TeacherCourses.Where(t => t.CourseId == courseId && t.TeacherId == teacherId)
                .ToList();
            if (teacheIsEist.Count == 0)
            {
                TeacherCourse teacherCourse = new TeacherCourse();
                teacherCourse.CourseId = courseId;
                teacherCourse.TeacherId = teacherId;
                teacherCourse.CreateDate = DateTime.Now;
                teacherCourse.IsActive = true;
                teacherCourse.IsDelete = false;
                _context.TeacherCourses.Add(teacherCourse);
                _context.SaveChanges();
                return teacherCourse.Id;
            }

            return 0;
        }


        //این متد همه فراگیران را واکشی میکند //

        public List<GetStudentListViewModel> GetStudents(int courseId)
        {

            List<int> listOfStudents = GetStudentsInClass(courseId).Select(u => u.UserId).ToList();


            return _context.UserRoles.Where(u => u.RoleId == 3 && !listOfStudents.Contains(u.UserId))
                .Select(u => new GetStudentListViewModel()
                {
                    UserId = u.UserId,
                    UserName = u.User.UserName,
                    FirstName = u.User.FirstName,
                    Email = u.User.Email,
                    LastName = u.User.LastName,
                    Mobile = u.User.Mobile,
                    UserAvatar = u.User.UserAvatar
                }).ToList();
        }

        public List<GetStudentListViewModel> GetStudentsInClass(int courseId)
        {
            return _context.UserCourses.Where(u => u.CourseId == courseId && u.IsDelete == false)
                .Select(u => new GetStudentListViewModel()
                {
                    UserId = (int)u.UserId,
                    UserName = u.User.UserName,
                    FirstName = u.User.FirstName,
                    Email = u.User.Email,
                    LastName = u.User.LastName,
                    Mobile = u.User.Mobile,
                    UserAvatar = u.User.UserAvatar
                }).ToList();
        }

        public int AddStudentToClass(int userId, int courseId)
        {
            if (!_context.UserCourses
                .Any(u => u.UserId == userId && u.CourseId == courseId && u.IsDelete == false))
            {
                UserCourse userCourse = new UserCourse();
                userCourse.UserId = userId;
                userCourse.CourseId = courseId;
                userCourse.IsDelete = false;
                _context.UserCourses.Add(userCourse);
                _context.SaveChanges();
                return userCourse.UC_Id;
            }

            return 0;
        }

        public void DeleteStudentFromClass(int userId, int courseId)
        {
            var userCourse = _context.UserCourses
                .Single(u => u.UserId == userId && u.CourseId == courseId && u.IsDelete == false);
            userCourse.IsDelete = true;
            _context.Update(userCourse);
            _context.SaveChanges();
        }

        public bool IsExistUserInClass(int userId, int courseId)
        {
            return _context.UserCourses.Any(u => u.UserId == userId && u.CourseId == courseId && u.IsDelete == false);
        }

        public List<GetStudentListViewModel> getStudentListForAddToClass(int teacherCourseId)
        {
            var query = from u in _context.Users
                        join ui in _context.UserRoles
                            on u.UserId equals ui.UserId
                        join s in _context.StudentCourses
                            on u.UserId equals s.StudentId
                        where (s.TeacherCourseId == teacherCourseId)
                        select (new GetStudentListViewModel()
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Mobile = u.Mobile,
                            UserName = u.UserName,
                            UserAvatar = u.UserAvatar,
                            UserId = u.UserId,
                            Email = u.Email

                        });

            return query.ToList();
        }

        public List<GetStudentListViewModel> getStudentListNotSelectedForAddToClass(int courseId)
        {
            var query = from u in _context.Users
                        join ui in _context.UserRoles
                            on u.UserId equals ui.UserId

                        // where (s.TeacherCourseId == teacherCourseId)
                        select (new GetStudentListViewModel()
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Mobile = u.Mobile,
                            UserName = u.UserName,
                            UserAvatar = u.UserAvatar,
                            UserId = u.UserId,
                            Email = u.Email

                        });

            return query.ToList();
        }

        public List<SelectListItem> GetGroupForManageCourse()
        {
            return _context.CourseGroups
                .Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageCourse(int groupId)
        {
            return _context.CourseGroups
                .Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<CourseGroup> GetAllGroups()
        {
            return _context.CourseGroups.ToList();
        }

        //public Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = "", string getType = "all", string orderByType = "date",
        //    int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0)
        //{
        //    if (take == 0)
        //        take = 8;

        //    IQueryable<Course> result = _context.Courses;

        //    if (!string.IsNullOrEmpty(filter))
        //    {
        //        result = result.Where(c => c.Title.Contains(filter) || c.Tags.Contains(filter));
        //    }

        //    switch (getType)
        //    {
        //        case "all":
        //            break;
        //        case "buy":
        //            {
        //                result = result.Where(c => c.CoursePrice != 0);
        //                break;
        //            }
        //        case "free":
        //            {
        //                result = result.Where(c => c.CoursePrice == 0);
        //                break;
        //            }

        //    }

        //    switch (orderByType)
        //    {
        //        case "date":
        //            {
        //                result = result.OrderByDescending(c => c.CreateDate);
        //                break;
        //            }
        //        case "updatedate":
        //            {
        //                result = result.OrderByDescending(c => c.UpdateDate);
        //                break;
        //            }
        //    }

        //    if (startPrice > 0)
        //    {
        //        result = result.Where(c => c.CoursePrice > startPrice);
        //    }

        //    if (endPrice > 0)
        //    {
        //        result = result.Where(c => c.CoursePrice < endPrice);
        //    }


        //    if (selectedGroups != null && selectedGroups.Any())
        //    {
        //        foreach (int groupId in selectedGroups)
        //        {
        //            result = result.Where(c => c.GroupId == groupId || c.SubGroup == groupId);
        //        }

        //    }

        //    int skip = (pageId - 1) * take;

        //    int pageCount = result.Include(c => c.CourseEpisodes).
        //        Include(c => c.User).Select(c => new ShowCourseListItemViewModel()
        //        {
        //            CourseId = c.Id,
        //            ImageName = c.CourseImage,
        //            Price = c.CoursePrice,
        //            Title = c.Title,
        //            Teacher = c.User.UserName
        //        }).Count() / take;

        //    var query = result.Include(c => c.CourseEpisodes).
        //        Include(c => c.User).Select(c => new ShowCourseListItemViewModel()
        //        {
        //            CourseId = c.Id,
        //            ImageName = c.CourseImage,
        //            Price = c.CoursePrice,
        //            Title = c.Title,
        //            Teacher = c.User.LastName,
        //            CourseEpisodes = c.CourseEpisodes
        //        }).Skip(skip).Take(take).ToList();

        //    return Tuple.Create(query, pageCount);
        //}

        List<ShowCourseListItemViewModel> ICourseService.GetCourseForHomePage()
        {
            IQueryable<Course> result = _context.Courses;

            var query = result.
                OrderByDescending(c => c.CreateDate).
                 Include(c => c.CourseEpisodes).
                 Select(c => new ShowCourseListItemViewModel()
                 {
                     CourseId = c.Id,
                     ImageName = c.CourseImage,
                     Price = c.CoursePrice,
                     Title = c.Title,
                     Teacher = c.User.LastName,
                     CourseEpisodes = c.CourseEpisodes
                 }).
                 Take(8).ToList();

            return query;
        }

        public CourseInArchiveViewModel GetCourseForArchive(int pageId = 1, string filter = "", string getType = "all",
            string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 8;

            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.Title.Contains(filter) || c.Tags.Contains(filter));
            }

            switch (getType)
            {
                case "all":
                    break;
                case "buy":
                    {
                        result = result.Where(c => c.CoursePrice != 0);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(c => c.CoursePrice == 0);
                        break;
                    }
            }

            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
            }

            if (startPrice > 0)
            {
                result = result.Where(c => c.CoursePrice > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.CoursePrice < endPrice);
            }

            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(c => c.GroupId == groupId || c.SubGroup == groupId);
                }
            }

            int takeDate = take;
            int skip = (pageId - 1) * take;

            CourseInArchiveViewModel list = new CourseInArchiveViewModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.CourseCounts = result.Count();
            list.ShowCourseList = result.OrderByDescending(c => c.CreateDate).
                Include(c => c.CourseEpisodes).
                Select(c => new ShowCourseListItemViewModel()
                {
                    CourseId = c.Id,
                    ImageName = c.CourseImage,
                    Price = c.CoursePrice,
                    Title = c.Title,
                    Teacher = c.User.LastName,
                    CourseEpisodes = c.CourseEpisodes
                }).Skip(skip).Take(takeDate).ToList();

            return list;
        }

        public void AddGroup(CourseGroup @group)
        {
            _context.CourseGroups.Add(group);
            _context.SaveChanges();
        }

        public CourseGroup GetById(int groupId)
        {
            return _context.CourseGroups.Find(groupId);
        }

        public void UpdateGroup(CourseGroup @group)
        {
            _context.CourseGroups.Update(group);
            _context.SaveChanges();
        }

        public Course GetCourseForShow(int courseId)
        {
            return
                _context.Courses.Include(c => c.CourseEpisodes)
                .Include(c => c.CourseStatus).Include(c => c.CourseLevel)
                .Include(c => c.User).Include(c => c.UserCourses)
                .FirstOrDefault(c => c.Id == courseId);
        }

        public bool CheckExistFile(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles", fileName);
            return File.Exists(path);
        }

        public int AddEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            episode.EpisodeFileName = episodeFile.FileName;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles", episode.EpisodeFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                episodeFile.CopyTo(stream);
            }

            _context.CourseEpisodes.Add(episode);
            _context.SaveChanges();
            return episode.EpisodeId;
        }

        public List<CourseEpisode> GetListEpisodeCorse(int courseId)
        {
            return _context.CourseEpisodes.Where(e => e.CourseId == courseId).ToList();
        }

        public CourseEpisode GetEpisodeById(int episodeId)
        {
            return _context.CourseEpisodes.Find(episodeId);
        }

        public void EditEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            if (episodeFile != null)
            {
                string deleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles", episode.EpisodeFileName);
                File.Delete(deleteFilePath);

                episode.EpisodeFileName = episodeFile.FileName;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles", episode.EpisodeFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    episodeFile.CopyTo(stream);
                }
            }

            _context.CourseEpisodes.Update(episode);
            _context.SaveChanges();
        }

        public List<SelectListItem> GetLevels()
        {
            return _context.CourseLevels.Select(l => new SelectListItem()
            {
                Value = l.LevelId.ToString(),
                Text = l.LevelTitle
            }).ToList();
        }

        public List<SelectListItem> GetStatues()
        {
            return _context.CourseStatus.Select(s => new SelectListItem()
            {
                Value = s.StatusId.ToString(),
                Text = s.StatusTitle
            }).ToList();
        }

        public void AddComment(CourseComment comment)
        {
            _context.CourseComments.Add(comment);
            _context.SaveChanges();
        }

        public Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.CourseComments.Count(c => !c.IsDelete && c.CourseId == courseId) / take;
            //int pageCount = _context.CourseComments.Where(c => !c.IsDelete && c.CourseId == courseId).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.CourseComments.Include(c => c.User).Where(c => !c.IsDelete && c.CourseId == courseId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }

        public List<ShowCourseListItemViewModel> GetPopularCourse()
        {
            return _context.Courses.Include(c => c.OrderDetails)
                .Where(c => c.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count)
                .Take(8)
                .Select(c => new ShowCourseListItemViewModel()
                {
                    CourseId = c.Id,
                    ImageName = c.CourseImage,
                    Price = c.CoursePrice,
                    Title = c.Title,
                    CourseEpisodes = c.CourseEpisodes
                })
                .ToList();
        }

        public int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImage = "no-photo.jpg";
            //TODO Check Image
            if (imgCourse != null && imgCourse.IsImage())
            {
                course.CourseImage = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoursesPic", course.CourseImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoursesPic/Thumb", course.CourseImage);

                imgResizer.Image_resize(imagePath, thumbPath, 250);
            }

            if (courseDemo != null)
            {
                course.DemoFileName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoursesPic/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }

            _context.Add(course);
            _context.SaveChanges();

            return course.Id;
        }

        public bool IsFree(int courseId)
        {
            return _context.Courses.Where(c => c.Id == courseId).Select(c => c.CoursePrice).First() == 0;
        }

        public Tuple<int, int> GetCourseVotes(int courseId)
        {
            var votes = _context.CourseVotes.Where(v => v.CourseId == courseId).Select(v => v.Vote).ToList();

            return Tuple.Create(votes.Count(c => c), votes.Count(c => !c));
        }

        public void AddsVote(int userId, int courseId, bool vote)
        {
            var UserVote = _context.CourseVotes.FirstOrDefault(c => c.UserId == userId && c.CourseId == courseId);
            if (UserVote != null)
            {
                UserVote.Vote = vote;
            }
            else
            {
                UserVote = new CourseVote()
                {
                    CourseId = courseId,
                    UserId = userId,
                    Vote = vote
                };
                _context.Add(UserVote);
            }

            _context.SaveChanges();
        }

        //public int AddCourse(Course course, IFormFile imageCourse)
        //{
        //    course.CreateDate = DateTime.Now;
        //    course.CourseImage = "CourseDefault.jpg";

        //    //Check Image

        //    if (imageCourse != null && imageCourse.IsImage())
        //    {
        //        course.CourseImage = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imageCourse.FileName);
        //        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoursesPic",
        //            course.CourseImage);
        //        using (var stream = new FileStream(imagePath, FileMode.Create))
        //        {
        //            imageCourse.CopyTo(stream);
        //        }

        //        //Resize Image//
        //        ImageConvertor imgResizer = new ImageConvertor();
        //        string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoursesPic/Thumb",
        //            course.CourseImage);
        //        imgResizer.Image_resize(imagePath, thumbPath, 75);
        //    }

        //    _context.Add(course);
        //    _context.SaveChanges();
        //    return course.Id;
        //}
    }

    //public int CreateVirtualClasses(VirtualClass virtualClass)
    //{
    //    _context.VirtualClasses.Add(virtualClass);
    //    _context.SaveChanges();
    //    return virtualClass.Id;
    //}
}

