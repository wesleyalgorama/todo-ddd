using Microsoft.AspNetCore.Mvc;
using Todo.Application.Services;
using Todo.Domain.Entities;
using Todo.Domain.Enums;
using Todo.Domain.Records;

namespace Todo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemController : ControllerBase
{
    private readonly ItemService _itemService;

    public ItemController(ItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet]
    public IActionResult GetItems()
    {
        var items = _itemService.GetItems();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public IActionResult GetItem(Guid id)
    {
        try
        {
            var item = _itemService.GetItem(id);
            return Ok(item);
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult CreateItem([FromBody] ItemCreateRecord itemCreateRecord)
    {
        try
        {
            var item = new Item(itemCreateRecord.Title, itemCreateRecord.Description);
            _itemService.CreateItem(item);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}/status")]
    public IActionResult ChangeItemStatus(Guid id, [FromBody] Status status)
    {
        try
        {
            _itemService.ChangeItemStatus(id, status);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}")]
    public IActionResult DeleteItem(Guid id)
    {
        try
        {
            _itemService.DeleteItem(id);
            return NoContent();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
}