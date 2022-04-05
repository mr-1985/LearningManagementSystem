using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;

namespace Lms.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistEmail(string email);
        int AddUserFromAdmin(UserViewModel.CreateUserViewModel model);
        int AddAgentFromAdmin(UserViewModel.CreateAgentViewModel model);
        bool IsExistMobile(string mobile);
        bool IsExistUserName(string username);
        User GetUserByUserName(string username);
        int GetUserIdByUserName(string username);
        User GetUserByEmail(string email);
        User GetUserByActivationCode(string activationCode);
        int AddUser(User user);
        User Login(LoginViewModel login);
        int RegisterAgent(RegisterAgentViewModel registerAgent);
        void ChangeUserPassword(string username, string newPassword);
        bool CompareOldPassword(string username, string oldPassword);
        bool ComparePasswords(string password, string rePassword);
        SideBarAdminPanelViewModel GetAdminPanelSideBarData(string username);
        InformationUserViewModel GetUserInformation(string username);
        InformationUserViewModel GetUserInformation(int userId);
        UserViewModel.EditUserViewModel GetUserForShowInEditMode(int userId);
        UserViewModel.EditAgentViewModel GetAgentForShowInEditMode(int userId);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void EditProfile(string username, EditProfileViewModel profile);
        Tuple<List<UserViewModel.UserForAdminListPageViewModel>, UserViewModel.UserForAdminViewModel> GetUsers(int PageId = 1, int take = 1, string filter = "");
        UserViewModel.AgentForAdminViewModel GetAgents(int PageId = 1, int take = 10, string filter = "");
        SideBarAdminPanelViewModel GetSideBarAdminPanelData(string username);
        //void DeleteUser(int userId);
        User GetUserById(int userId);
        void EditUserFromAdmin(UserViewModel.EditUserViewModel editUser);
        void EditAgentFromAdmin(UserViewModel.EditAgentViewModel editAgent);
        User LoginUser(LoginViewModel login);
        bool ActiveAccount(string activeCode);
        InformationUserPanelViewModel GetUserPanelInformation(string userName);
        void UpdateUser(User user);

        #region Wallet

        int BalanceUserWallet(string userName);
        List<WalletViewModel> GetWalletUser(string userName);
        int ChargeWallet(string userName, int amount, string description, bool isPay = false);
        int AddWallet(Wallet wallet);

        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);

        #endregion
    }
}
