namespace Todo.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Enums;
using Todo.Domain.Interfaces;

public class ItemRepository : IItemRepository
{
    public void ChangeStatus(Status status)
    {
        throw new NotImplementedException();
    }

    public Item GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Item> GetItems()
    {
        throw new NotImplementedException();
    }
}