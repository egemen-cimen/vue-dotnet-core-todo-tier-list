using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoTierListController : ControllerBase
    {
        private readonly ILogger<TodoTierListController> _logger;
        public static List<TodoListItem> todoItems = new List<TodoListItem>();


        public TodoTierListController(ILogger<TodoTierListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TodoListItem> Get()
        {
            return todoItems.FindAll(i => i.Status != TodoColumn.Trashed).ToArray();
        }

        [HttpPut]
        public int Put(TodoListItem todoListItem)
        {
            todoListItem.Id = todoItems.Count;
            todoItems.Add(todoListItem);
            return todoListItem.Id;
        }

        [HttpPost]
        public bool Post(List<TodoListItem> todoListItems)
        {
            foreach (var todoItem in todoListItems)
            {
                if (todoItems[todoItem.Id].Status != todoItem.Status)
                {
                    Console.WriteLine("Id for " + todoItem.Text + ": " + todoItem.Id + " (" + todoItems[todoItem.Id].Status + " -> " + todoItem.Status + ")");
                    todoItems[todoItem.Id].Status = todoItem.Status;
                }
            }
            Console.WriteLine("====");
            return true;
        }
    }
}
