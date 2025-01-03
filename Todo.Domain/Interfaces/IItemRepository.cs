namespace Todo.Domain.Interfaces;

using Todo.Domain.Entities;
using Todo.Domain.Enums;

public interface IItemRepository
{
    IEnumerable<Item> GetItems();
    Item GetItem(Guid id);
    void ChangeStatus(Status status);
}