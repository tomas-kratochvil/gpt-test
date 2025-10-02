using Demolice.Data.Enums;

namespace Demolice.Data;

public class Email
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Subject { get; set; }
    public string Text { get; set; }
    public Mood Mood { get; set; }
    public Priority Priority { get; set; }
}