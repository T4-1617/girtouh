using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WinUpp_220916
{
    class Customer
    {
        public ArrayList CustomerAccounts;

        public Customer()
        {
            CustomerAccounts = new ArrayList();
        }


        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public AccountforCustomer GetCustomerAccount(int CustomerAccountIndex)
        {
            return (AccountforCustomer)CustomerAccounts[CustomerAccountIndex];
        }


        public ArrayList GetCusomterAccounts()
        {
            return CustomerAccounts;
        }


        public void FundsforAccount(decimal InitialDeposit)
        {
            if (InitialDeposit >= 1000)
            {
                AccountforCustomer a = new AccountforCustomer(InitialDeposit);

                CustomerAccounts.Add(a);
            }

        }


        public override string ToString()
        {
            return string.Format("{0} {1}", CustomerFirstName, CustomerLastName);
        }

    }

    public class AccountforCustomer
    {
        private decimal balance;


        public string AccountName { get; set; }

        private ArrayList transactions;

        public AccountforCustomer(decimal starting_fund)
        {
            transactions = new ArrayList();

            balance = starting_fund;
        }

        public ArrayList GetTransactions()
        {
            return transactions;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Withdraw(decimal changedamount)
        {
            //Transaction g = new Transaction();
            balance = balance - changedamount;

            transactions.Add(new Transaction() { Amount = changedamount, TransactionType = "Withdrew", AccountTransactionName= AccountName });
        }

        public void Deposit(decimal changedamount)
        {
            balance = balance + changedamount;

            //Transaction y = new Transaction();
            //y.Amount = changedamount;
            //y.TransactionType = "Deposit";

            transactions.Add(new Transaction() { Amount = changedamount, TransactionType = "Deposit", AccountTransactionName = AccountName });
        }

        public override string ToString()
        {
            return string.Format("{0}", AccountName);
        }
    }

    public class Transaction
    {
        public string AccountTransactionName { get; set; }

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }

        public override string ToString()
        {
            return string.Format("{0} SEK {1}: {2} ", Amount, TransactionType, AccountTransactionName);
        }

    }
}
