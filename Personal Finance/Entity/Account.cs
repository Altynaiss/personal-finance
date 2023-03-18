namespace Personal_Finance.Entity
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
