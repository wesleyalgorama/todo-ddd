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

    public void ChangeStatus(Status status)
    {
        _itemRepository.ChangeStatus(status);
    }
}