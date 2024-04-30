namespace facade_company;


class Meeting(string topic, DateTime date, string location)
{
    private string Topic { get; } = topic;
    private DateTime Date { get; } = date;
    private string Location { get; } = location;

    public void Schedule()
    {
        Console.WriteLine($"Meeting '{Topic}' scheduled on {Date.ToShortDateString()} at {Date.ToShortTimeString()} in {Location}");
    }
}