namespace Demolice.Data;

public class Subscription
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Plan { get; set; }
}