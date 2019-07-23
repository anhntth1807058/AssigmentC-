namespace Banking.entity
{
    public class SHBAccount
    {
        public SHBAccount()
        {
        }

        public SHBAccount(string accountNumber, string userName, string password, double balance, int status)
        {
            AccountNumber = accountNumber;
            UserName = userName;
            Password = password;
            Balance = (decimal) balance;
            Status = status;
        }

        public string AccountNumber { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public decimal Balance { get; set; }

        public int Status { get; set; }

        public override string ToString()
        {
            return $"Username: {UserName} || Balance: {Balance}";
        }
    }
}