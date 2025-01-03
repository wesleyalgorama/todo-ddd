namespace Todo.Domain.Interfaces;

using Todo.Domain.Entities;
using Todo.Domain.Enums;

public interface IItemRepository
{
    IEnumerable<Item> GetItems();
    Item GetItem(Guid id);
    void CreateItem(Item item);
    void ChangeItemStatus(Guid id, Status status);
    void DeleteItem(Guid id);
}