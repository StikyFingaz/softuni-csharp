namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            BankAccount account1 = new("1234567890", "Peter");
            Console.WriteLine(account1.AccountID);
        }
    }

    public class BankAccount
    {
        private string accountID = string.Empty;
        private string owner = string.Empty;

        public string AccountID
        {
            get { return accountID; }
            set
            {
                accountID = ValidAccountNumber(value)
                    ? value
                    : throw new ArgumentException(nameof(AccountID));
            }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public BankAccount(string accountID, string owner)
        {
            AccountID = accountID;
            Owner = owner;
        }

        public static bool ValidAccountNumber(string accountID) =>
            accountID.Length == 10 && accountID.All(char.IsDigit);
    }
}
