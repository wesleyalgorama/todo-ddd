namespace Todo.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Enums;
using Todo.Domain.Interfaces;

public class ItemRepository : IItemRepository
{
    private readonly List<Item> _items;

    public ItemRepository()
    {
        _items = new List<Item>();
    }

    public Item GetItem(Guid id)
    {
        var item = _items.FirstOrDefault(item => item.Id == id);
        if (item == null) throw new Exception("Not found");
        return item;
    }

    public IEnumerable<Item> GetItems()
    {
        return _items;
    }

    public void CreateItem(Item item)
    {
        _items.Add(item);
    }

    public void ChangeItemStatus(Guid id, Status status)
    {
        var item = GetItem(id);
        item.ChangeItemStatus(status);
    }

    public void DeleteItem(Guid id)
    {
        var item = GetItem(id);
        _items.Remove(item);
    }
}