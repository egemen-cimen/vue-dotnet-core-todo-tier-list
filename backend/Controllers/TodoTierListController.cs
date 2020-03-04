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

        public TodoTierListController(ILogger<TodoTierListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TodoListItem> Get()
        {
            using (var db = new TodoListItemContext())
            {
                var todoItems = db.TodoListItems
                    .Where(i => i.Status != TodoColumn.Trashed)
                    .ToList();
                return todoItems;
            }
        }

        [HttpPut]
        public int Put(TodoListItem todoListItem)
        {
            using (var db = new TodoListItemContext())
            {
                var todoListItemId = db.TodoListItems
                    .Where(i => i.Status != TodoColumn.Trashed)
                    .ToList()
                    .Count;

                todoListItem.Id = ++todoListItemId;
                db.TodoListItems.Add(todoListItem);
                db.SaveChanges();
                return todoListItemId;
            }
        }

        [HttpPost]
        public bool Post(List<TodoListItem> todoListItems)
        {
            foreach (var todoItem in todoListItems)
            {/*
                if (todoItems[todoItem.Id].Status != todoItem.Status)
                {
                    todoItems[todoItem.Id].Status = todoItem.Status;
                }
            */
            }
            return true;
        }
    }
}
