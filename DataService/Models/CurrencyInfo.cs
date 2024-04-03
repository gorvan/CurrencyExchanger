namespace DataService.Models
{
    public class CurrencyInfo
    {
        public int Id { get; set; }
        public int Cur_Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public decimal Rate { get; set; }
        public DateTime LastUpdate { get; set; }
        public decimal Amount { get; set; } = 1;
        public int Scale { get; set; } = 1;
        public bool IsMain { get; set; }
    }
}
