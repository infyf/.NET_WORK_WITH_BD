namespace lr12_bd.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int NumberOfEmployees { get; set; }
    }
}
