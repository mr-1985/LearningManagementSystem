using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;

namespace Lms.Core.Services.Interfaces
{
    public interface IBankService
    {
        List<Bank> GetAllBanks();

        Bank GetBankById(int bankId);

        void EditBank(Bank bank);
        void EditBank(BankViewModel bank);
    }
}
