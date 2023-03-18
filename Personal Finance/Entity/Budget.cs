namespace Personal_Finance.Entity
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
