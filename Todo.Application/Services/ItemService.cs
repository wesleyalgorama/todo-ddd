using Todo.Domain.Entities;
using Todo.Domain.Enums;
using Todo.Domain.Interfaces;

namespace Todo.Application.Services;

public class ItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public IEnumerable<Item> GetItems()
    {
        return _itemRepository.GetItems();
    }

    public Item GetItem(Guid id)
    {
        return _itemRepository.GetItem(id);
    }

    public void CreateItem(Item item)
    {
        _itemRepository.CreateItem(item);
    }

    public void ChangeItemStatus(Guid id, Status status)
    {
        _itemRepository.ChangeItemStatus(id, status);
    }

    public void DeleteItem(Guid id)
    {
        _itemRepository.DeleteItem(id);
    }
}