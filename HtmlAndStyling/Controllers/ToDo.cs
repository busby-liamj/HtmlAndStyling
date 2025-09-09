using HtmlAndStyling.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndStyling.Controllers;

public class ToDo : Controller
{
    private static readonly List<ToDoItem> Items = [];
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ToDoItem item)
    {
        
        Items.Add(item);
        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        return View(Items);
    }

    public IActionResult Delete(Guid id)
    {
        int? index = null;
        for (int i=0; i<Items.Count; i++)
        {
            ToDoItem item = Items[i];
            if (item.Id != id)
            {
                continue;
            }
            
            index = i;
            break;
        }
        
        if (index is null)
            return RedirectToAction("Index");
        
        Items.RemoveAt((int)index);
        return RedirectToAction("Index");
    }
}