namespace Personal_Finance.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public string Desctiption { get; set; }
    }
}
