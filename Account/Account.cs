using System;

namespace Account
{
    public class Account
    {
        private int id;
        private decimal balance;
        private DateTime created;

        public Account(int id, decimal balance, DateTime created)
        {
            Id = id;
            Balance = balance;
            Created = created;
        }

        public int Id {
                        get {
                                return id; 
                            }
                        set {
                                
                            }
                       }

        public decimal Balance { get { return balance; } set { } }

        public DateTime Created { get { return created; } set { } }


        public Account(decimal initalBalance)
        {

        }

        public void Withdraw(decimal amount)
        {

        }

        public void Desposit(decimal amount)
        {

        }

        //public int GetDaysSinceCreation()
        //{

        //}

        public static (bool isValid, string errorMessage) ValidateId(int id)
        {
            return (true, "");
        }

        public static (bool isValid, string errorMessage) ValidateBalance(decimal balance)
        {
            return (true, "");
        }
    }
}
