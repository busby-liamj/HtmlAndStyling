namespace HtmlAndStyling.Models;

public class ToDoItem
{
    public Guid Id { get; init; } = Guid.NewGuid(); 

    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int Priority { get; set; } = 1;
    public bool IsCompleted { get; set; }

    public string PriorityColor()
    {
        return Priority switch
        {
            1 => "red",
            2 => "orange",
            3 => "yellow",
            4 => "lime",
            5 => "lavender",
            _ => "black"
        };
    }
}