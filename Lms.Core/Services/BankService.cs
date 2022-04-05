using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;

namespace Lms.Core.Services
{
    public class BankService : IBankService
    {
        private LmsContext _Context;

        public BankService(LmsContext context)
        {
            _Context = context;
        }
        public List<Bank> GetAllBanks()
        {
            return _Context.Banks.ToList();
        }

        public Bank GetBankById(int bankId)
        {
            return _Context.Banks.Find(bankId);
        }

        public void EditBank(Bank bank)
        {
            _Context.Update(bank);
            _Context.SaveChanges();
        }

        public void EditBank(BankViewModel bank)
        {

            var banksFind = _Context.Banks.Find(bank.BankId);
            //banksFind.Percent = bank.Percent;
            _Context.Update(banksFind);
            _Context.SaveChanges();
        }
    }
}
