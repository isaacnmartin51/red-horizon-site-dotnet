namespace RedHorizonSite.Data;

public class Booking 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime Date { get; set; }
    public string Details { get; set; }
}