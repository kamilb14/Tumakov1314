using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1314
{
     class BankAccount
    {
        
            private ushort AccountNumber;
            private decimal Balance;
            private AccountType AccountType;
            private static ushort uniq_num;

            bool disposed = false;
            public BankAccount()
            {
                AccountNumber = UniqNumber();
                AccountType = Type();
                Balance = 0;
            }
            public BankAccount(AccountType AccountType)
            {
                AccountNumber = UniqNumber();
                this.AccountType = AccountType;
                Balance = 0;
            }
            public BankAccount(decimal Balance)
            {
                AccountNumber = UniqNumber();
                AccountType = Type();
                this.Balance = Balance;
            }
            public BankAccount(AccountType AccountType, decimal Balance)
            {
                AccountNumber = UniqNumber();
                this.AccountType = AccountType;
                this.Balance = Balance;
            }
            public ushort UniqNumber()
            {
                return uniq_num++;
            }
            public AccountType Type()
            {
                return AccountType;
            }
            public decimal Balance_account()
            {
                return Balance;
            }
            public override string ToString()
            {
                return $"Номер счёта: {AccountNumber}\n Баланс: {Balance} Тип счёта: {AccountType}";

            }

            [Conditional("DEBUG_ACCOUNT")]
            public void DumpToScreen()
            {
                Console.WriteLine(ToString());
            }
        }
    }

