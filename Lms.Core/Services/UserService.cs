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
using Microsoft.EntityFrameworkCore;

namespace Lms.Core.Services
{
    public class UserService : IUserService
    {
        //private LmsContext _context;
        //private IHostingEnvironment _environment;
        //private IPermissionService _permissionService;

        //public UserService(LmsContext context, IHostingEnvironment environment, IPermissionService permissionService)
        //{
        //    _context = context;
        //    _environment = environment;
        //    _permissionService = permissionService;
        //}

        private LmsContext _context;
        public UserService(LmsContext context)
        {
            _context = context;
        }

        public int AddUserFromAdmin(UserViewModel.CreateUserViewModel model)
        {
            User user = new User();
            user.Email = model.Email;
            user.UserName = model.UserName.Trim();
            user.CreateDate = DateTime.Now;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.IsActive = model.IsActive;
            user.Mobile = model.Mobile.Trim();
            user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            user.BirthDate = DateTime.Now;

            #region Save Avatar

            if (model.UserAvatar != null)
            {
                string imagePath = "";

                //-------Upload New User Image --------//
                user.UserAvatar = GeneratorName.GenrateUniqeCode() + Path.GetExtension(model.UserAvatar.FileName);

                //imagePath = Path.Combine(_environment.WebRootPath, "UserAvatar", user.UserAvatar);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(stream);
                }
            }

            if (model.UserAvatar == null)
            {
                user.UserAvatar = "default.png";
            }

            #endregion

            return AddUser(user);
        }

        public int AddAgentFromAdmin(UserViewModel.CreateAgentViewModel model)
        {
            User user = new User();
            user.Email = model.Email;
            user.UserName = model.UserName.Trim();
            user.CreateDate = DateTime.Now;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.IsActive = model.IsActive;
            user.Mobile = model.Mobile.Trim();
            user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            user.BirthDate = DateTime.Now;
            user.CityId = model.CityId;
            user.Address = model.Address;

            #region Save Avatar

            if (model.UserAvatar != null)
            {
                string imagePath = "";

                //-------Upload New User Image --------//
                user.UserAvatar = GeneratorName.GenrateUniqeCode() + Path.GetExtension(model.UserAvatar.FileName);

                //imagePath = Path.Combine(_environment.WebRootPath, "UserAvatar", user.UserAvatar);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(stream);
                }
            }

            if (model.UserAvatar == null)
            {
                user.UserAvatar = "default.png";
            }

            #endregion

            int userid = AddUser(user);
            Agent agent = new Agent()
            {
                AgentName = model.AgentName,
                UserId = userid,
                ContractNo = model.ContractNo,
                Description = model.Description,
                IsActive = model.IsActive,
                IsDelete = false,
                Percent = model.AgentPercent,


            };

            return AddAgent(agent);
        }


        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserByActivationCode(string activationCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActivationCode == activationCode);
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public int AddAgent(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
            return agent.UserId;
        }

        public void EditProfile(string username, EditProfileViewModel profile)
        {
            if (profile.UserAvatar != null)
            {
                string imagePath = "";
                if (profile.AvatarName != "Defult.jpg")
                {
                    //------Delete User Image --------//
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                //-------Upload New User Image --------//
                profile.AvatarName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(profile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    profile.UserAvatar.CopyTo(stream);
                }

            }

            var user = GetUserByUserName(username);
            user.UserName = profile.UserName;
            user.Email = profile.Email;
            user.UserAvatar = profile.AvatarName;

            UpdateUser(user);

        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();

        }

        public bool ComparePasswords(string password, string rePassword)
        {
            if (password == rePassword)
            {
                return true;
            }

            return false;
        }

        public SideBarAdminPanelViewModel GetAdminPanelSideBarData(string username)
        {
            return _context.Users.Where(u => u.UserName == username).
                Select(u => new SideBarAdminPanelViewModel()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Avatar = u.UserAvatar

                }).Single();
        }

        public void EditUserFromAdmin(UserViewModel.EditUserViewModel editUser)
        {
            var user = GetUserById(editUser.UserId);
            user.FirstName = editUser.FirstName;
            user.LastName = editUser.LastName;
            user.Mobile = editUser.Mobile;
            user.IsActive = editUser.IsActive;
            user.Email = editUser.Email;

            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }

            if (editUser.UserAvatar != null)
            {
                string imagePath = "";
                if (editUser.AvatarName != "default.png")
                {
                    //------Delete User Image --------//
                    //imagePath = Path.Combine(_environment.WebRootPath, "UserAvatar", editUser.AvatarName);
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }

                }

                //-------Upload New User Image --------//
                editUser.AvatarName =
                    GeneratorName.GenrateUniqeCode() + Path.GetExtension(editUser.UserAvatar.FileName);


                //imagePath = Path.Combine(_environment.WebRootPath, "UserAvatar", editUser.AvatarName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatarName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editUser.UserAvatar.CopyTo(stream);
                }
            }

            user.UserAvatar = editUser.AvatarName;
            _context.Users.Update(user);
            _context.SaveChanges();


        }

        public UserViewModel.EditAgentViewModel GetAgentForShowInEditMode(int userId)
        {

            var query = from a in _context.Agents
                        join
                            u in _context.Users
                            on a.UserId equals u.UserId
                        join c in _context.Cities
                            on u.CityId equals c.CityId
                        where a.UserId == userId
                        select (new UserViewModel.EditAgentViewModel()
                        {
                            AgentName = a.AgentName,
                            AgentPercent = a.Percent,
                            CityId = u.CityId,
                            ProvinceId = c.ProvinceId,
                            ContractNo = a.ContractNo,
                            Description = a.Description,
                            Email = u.Email,
                            FirstName = u.FirstName,
                            IsActive = u.IsActive,
                            LastName = u.LastName,
                            Mobile = u.Mobile,
                            UserId = u.UserId,
                            UserName = u.UserName,
                            Address = u.Address

                        });
            return query.Single();
        }

        public EditProfileViewModel GetDataForEditProfileUser(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Mobile = u.Mobile,
                AvatarName = u.UserAvatar,
                Email = u.Email,
                //Tell = u.Tell,
                UserName = u.UserName,

            }).Single();
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public int GetUserIdByUserName(string username)
        {
            return _context.Users.Single(u => u.UserName == username).UserId;
        }

        //public void DeleteUser(int userId)
        //{
        //    var user = GetUserById(userId);
        //    user.IsDelete = true;
        //    UpdateUser(user);
        //    _permissionService.RemoveRolesUser(user.UserId);
        //}

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }
        public Agent GetAgentByUserId(int userId)
        {
            return _context.Agents.Single(u => u.UserId == userId);
        }
        public UserViewModel.EditUserViewModel GetUserForShowInEditMode(int userId)
        {
            return _context.Users.Where(u => u.UserId == userId).Select(u => new UserViewModel.EditUserViewModel()
            {
                Email = u.Email,
                AvatarName = u.UserAvatar,
                FirstName = u.FirstName,
                IsActive = u.IsActive,
                LastName = u.LastName,
                Mobile = u.Mobile,
                UserId = u.UserId,
                UserName = u.UserName,
                UserRoles = u.UserRoles.Select(r => r.RoleId).ToList(),

            }).Single();
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);
            InformationUserViewModel information = new InformationUserViewModel();
            information.Email = user.Email;
            information.FirstName = user.FirstName;
            information.LastName = user.LastName;
            information.Mobile = user.Mobile;
            information.RegisterDate = user.CreateDate;
            information.Tell = user.Tell;

            information.UserAvatar = user.UserAvatar;
            return information;
        }

        public bool IsExistEmail(string Email)
        {
            return _context.Users.Any(u => u.Email == Email);
        }

        public bool IsExistMobile(string Mobile)
        {
            return _context.Users.Any(u => u.Mobile == Mobile);
        }

        public bool IsExistUserName(string UserName)
        {
            return _context.Users.Any(u => u.UserName == UserName);
        }

        public Tuple<List<UserViewModel.UserForAdminListPageViewModel>, UserViewModel.UserForAdminViewModel> GetUsers(int PageId = 1, int take = 1, string filter = "")
        {

            //var result = from u in _context.Users
            //             join ui in _context.UserRoles
            //                 on u.UserId equals ui.UserId
            //             join r in _context.Roles
            //                 on ui.RoleId equals r.RoleId
            //             where (u.IsDelete == false)
            //             select new UserViewModel.UserForAdminListPageViewModel()
            //             {
            //                 RoleName = r.RoleTitle,
            //                 UserId = u.UserId,
            //                 CreateDate = u.CreateDate,
            //                 FirstName = u.FirstName,
            //                 IsActive = u.IsActive,
            //                 LastName = u.LastName,
            //                 Mobile = u.Mobile,
            //                 UserAvatar = u.UserAvatar,
            //                 UserName = u.UserName,
            //                 IsDeleted = u.IsDelete,
            //                 Email = u.Email,
            //             };
            //if (!string.IsNullOrEmpty(filter))
            //{

            //    result = from u in _context.Users
            //             join ui in _context.UserRoles
            //                 on u.UserId equals ui.UserId
            //             join r in _context.Roles
            //                 on ui.RoleId equals r.RoleId
            //             where ((u.UserName.Contains(filter) || u.FirstName.Contains(filter) || u.LastName.Contains(filter) ||
            //                    u.Mobile.Contains(filter) || r.RoleName.Contains(filter)) && u.IsDelete == false)

            //             select new UserViewModel.UserForAdminListPageViewModel()
            //             {
            //                 RoleName = r.RoleTitle,
            //                 UserId = u.UserId,
            //                 CreateDate = u.CreateDate,
            //                 FirstName = u.FirstName,
            //                 IsActive = u.IsActive,
            //                 LastName = u.LastName,
            //                 Mobile = u.Mobile,
            //                 UserAvatar = u.UserAvatar,
            //                 UserName = u.UserName,
            //                 IsDeleted = u.IsDelete,
            //                 Email = u.Email,
            //             };
            //}

            IQueryable<User> result = _context.Users;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(u => u.UserName.Contains(filter) || u.FirstName.Contains(filter) || u.LastName.Contains(filter) ||
                                      u.Mobile.Contains(filter));
            }

            int takeDate = take;
            int skip = (PageId - 1) * takeDate;

            UserViewModel.UserForAdminViewModel list = new UserViewModel.UserForAdminViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.Users = result.OrderByDescending(u => u.CreateDate).Where(u => u.IsDelete == false).Skip(skip).Take(takeDate).ToList();
            list.UserCounts = _context.Users.Count();

            var query = result.Select(u => new UserViewModel.UserForAdminListPageViewModel
            {
                //RoleName = r.RoleTitle,
                UserId = u.UserId,
                CreateDate = u.CreateDate,
                FirstName = u.FirstName,
                IsActive = u.IsActive,
                LastName = u.LastName,
                Mobile = u.Mobile,
                UserAvatar = u.UserAvatar,
                UserName = u.UserName,
                IsDeleted = u.IsDelete,
                Email = u.Email
            }).Skip(skip).Take(takeDate).ToList();

            return Tuple.Create(query, list);
        }

        public User Login(LoginViewModel login)
        {
            string password = PasswordHelper.EncodePasswordMd5(login.Password);
            // var t= _context.Users.FirstOrDefault(u => u.UserName == login.UserName && u.Password == password);
            return _context.Users.FirstOrDefault(u => u.UserName == login.UserName.Trim() && u.Password == password);
        }

        public int RegisterAgent(RegisterAgentViewModel RegisterAgent)
        {
            User user = new User
            {
                ActivationCode = RegisterAgent.ActivationCode,
                Address = RegisterAgent.Address,
                BirthDate = RegisterAgent.BirthDate,
                CityId = 1,
                CreateDate = DateTime.Now,
                Email = RegisterAgent.Email,
                FirstName = RegisterAgent.FirstName,
                IsActive = RegisterAgent.IsActive,
                IsDelete = false,
                LastName = RegisterAgent.LastName,
                Mobile = RegisterAgent.Mobile,
                NationalCode = RegisterAgent.NationalCode,
                Password = RegisterAgent.Password,
                SerialeShenasnameh = RegisterAgent.SerialeShenasnameh,
                ShomarehShenasnameh = RegisterAgent.ShomarehShenasnameh,
                Tell = RegisterAgent.Tell,
                UserAvatar = RegisterAgent.UserAvatar,
                UserName = RegisterAgent.UserName
            };
            _context.Users.Add(user);
            int userid = user.UserId;
            Agent agent = new Agent
            {
                ContractNo = RegisterAgent.ContractNo,
                Description = RegisterAgent.Description,
                IsActive = RegisterAgent.IsActive,
                IsDelete = RegisterAgent.IsDelete,
                Percent = RegisterAgent.Percent,
                UserId = userid
            };
            _context.Agents.Add(agent);
            _context.SaveChanges();
            return agent.AgentId;
        }

        public void ChangeUserPassword(string username, string newPassword)
        {
            var user = GetUserByUserName(username);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public bool CompareOldPassword(string username, string oldPassword)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.UserName == username && u.Password == hashOldPassword);
        }

        public SideBarAdminPanelViewModel GetSideBarAdminPanelData(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new SideBarAdminPanelViewModel()
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Avatar = u.UserAvatar
            }).Single();
        }

        public InformationUserViewModel GetUserInformation(int userId)
        {
            var user = GetUserById(userId);
            InformationUserViewModel information = new InformationUserViewModel();
            information.Email = user.Email;
            information.FirstName = user.FirstName;
            information.LastName = user.LastName;
            information.Mobile = user.Mobile;
            information.RegisterDate = user.CreateDate;
            information.Wallet = 0; // BalanceWalletUser(user.Email);
            information.UserAvatar = user.UserAvatar;
            return information;
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string userName = login.UserName;
            return _context.Users.Include(u=>u.UserRoles).SingleOrDefault(u => u.UserName == userName && u.Password == hashPassword);
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActivationCode == activeCode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActivationCode = GeneratorName.GenrateUniqeCode();
            _context.SaveChanges();

            return true;
        }

        public InformationUserPanelViewModel GetUserPanelInformation(string userName)
        {
            var user = GetUserByUserName(userName);
            InformationUserPanelViewModel information = new InformationUserPanelViewModel();
            information.UserName = user.UserName;
            information.FirstName = user.FirstName;
            information.LastName = user.LastName;
            information.Email = user.Email;
            information.RegisterDate = user.CreateDate;
            information.Mobile = user.Mobile;
            information.Wallet = BalanceUserWallet(userName);

            return information;
        }

        public int BalanceUserWallet(string userName)
        {
            int userId = GetUserIdByUserName(userName);

            //-----------واریز--------------------------------------------//
            var enter = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay)
                .Select(w => w.Amount).ToList();

            //---------برداشت ---------------------------------------------//
            var exit = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 2)
                .Select(w => w.Amount).ToList();

            return (enter.Sum() - exit.Sum());
        }

        public List<WalletViewModel> GetWalletUser(string userName)
        {
            int userId = GetUserIdByUserName(userName);

            return _context.Wallets
                .Where(w => w.IsPay && w.UserId == userId)
                .Select(w => new WalletViewModel()
                {
                    Amount = w.Amount,
                    DateTime = w.CreateDate,
                    Description = w.Description,
                    Type = w.TypeId
                })
                .ToList();
        }

        public int ChargeWallet(string userName, int amount, string description, bool isPay = false)
        {

            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                IsPay = isPay,
                TypeId = 1,
                UserId = GetUserIdByUserName(userName)
            };
            return AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletByWalletId(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }

        public UserViewModel.AgentForAdminViewModel GetAgents(int PageId = 1, int take = 10, string filter = "")
        {
            var result = from o in _context.Agents
                         join u in _context.Users
                             on o.UserId equals u.UserId
                         join c in _context.Cities
                             on u.CityId equals c.CityId
                         join p in _context.Provinces
                             on c.ProvinceId equals p.ProvinceId
                         where u.IsDelete == false
                         select (new UserViewModel.AgentViewModel()
                         {
                             Mobile = u.Mobile,
                             FirstName = u.FirstName,
                             LastName = u.LastName,
                             CityName = c.CityName,
                             ProvinceName = p.ProvinceName,
                             CreateDate = u.CreateDate,
                             UserId = u.UserId,
                             ContractNo = o.ContractNo,
                             Description = o.Description,
                             AgentPercent = o.Percent,
                             UserName = u.UserName,
                             AgentName = o.AgentName,
                             IsActive = u.IsActive,
                             UserAvatar = u.UserAvatar
                         });
            if (!string.IsNullOrEmpty(filter))
            {
                result = from o in _context.Agents
                         join u in _context.Users
                             on o.UserId equals u.UserId
                         join c in _context.Cities
                             on u.CityId equals c.CityId
                         join p in _context.Provinces
                             on c.ProvinceId equals p.ProvinceId
                         where (c.CityName.Contains(filter) ||
                               p.ProvinceName.Contains(filter) ||
                               o.AgentName.Contains(filter) ||
                               u.Mobile.Contains(filter) ||
                               u.UserName.Contains(filter) ||
                               u.FirstName.Contains(filter) ||
                               u.LastName.Contains(filter))
                                && u.IsDelete == false

                         select (new UserViewModel.AgentViewModel()
                         {
                             Mobile = u.Mobile,
                             FirstName = u.FirstName,
                             LastName = u.LastName,
                             CityName = c.CityName,
                             ProvinceName = p.ProvinceName,
                             CreateDate = u.CreateDate,
                             UserId = u.UserId,
                             ContractNo = o.ContractNo,
                             Description = o.Description,
                             AgentPercent = o.Percent,
                             UserName = u.UserName,
                             AgentName = o.AgentName,
                             IsActive = u.IsActive,
                             UserAvatar = u.UserAvatar
                         });
            }

            int takeDate = take;
            int skip = (PageId - 1) * takeDate;
            UserViewModel.AgentForAdminViewModel list = new UserViewModel.AgentForAdminViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.Users = result.OrderByDescending(o => o.CreateDate).Skip(skip).Take(takeDate).ToList();
            list.UserCounts = _context.Agents.Count();
            return list;
        }

        public void EditAgentFromAdmin(UserViewModel.EditAgentViewModel editAgent)
        {
            var user = GetUserById(editAgent.UserId);

            user.Address = editAgent.Address;
            user.CityId = editAgent.CityId;
            user.FirstName = editAgent.FirstName;
            user.LastName = editAgent.LastName;
            user.Email = editAgent.Email;
            user.Mobile = editAgent.Mobile;


            if (!string.IsNullOrEmpty(editAgent.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editAgent.Password);
            }

            _context.Users.Update(user);
            _context.SaveChanges();
            var agent = GetAgentByUserId(editAgent.UserId);
            agent.AgentName = editAgent.AgentName;
            agent.ContractNo = editAgent.ContractNo;
            agent.Description = editAgent.Description;
            agent.IsActive = editAgent.IsActive;
            agent.Percent = editAgent.AgentPercent;
            _context.Agents.Update(agent);
            _context.SaveChanges();
        }
    }
}
