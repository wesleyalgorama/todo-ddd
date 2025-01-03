using Todo.Domain.Enums;

namespace Todo.Domain.Entities;

public class Item
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }

    public Item(string title, string description)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Status = Status.Todo;
    }

    public void ChangeItemStatus(Status status)
    {
        Status = status;
    }
}