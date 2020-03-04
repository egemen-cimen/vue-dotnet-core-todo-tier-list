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
                var lastTodoListItem = db.TodoListItems
                    .ToList().LastOrDefault();
                int todoListItemId = 0;

                if (lastTodoListItem != null)
                {
                    todoListItemId = lastTodoListItem.Id;
                }
                todoListItem.Id = ++todoListItemId;
                db.TodoListItems.Add(todoListItem);
                db.SaveChanges();

                return todoListItemId;
            }
        }

        [HttpPost]
        public bool Post(List<TodoListItem> todoListItems)
        {

            using (var db = new TodoListItemContext())
            {
                foreach (var todoItem in todoListItems)
                {
                    var dbTodoItem = db.TodoListItems
                        .Where(i => i.Status != todoItem.Status && i.Id == todoItem.Id);

                    if (dbTodoItem != null && dbTodoItem.Count() > 0)
                    {
                        dbTodoItem.First().Status = todoItem.Status;
                    }
                }
                db.SaveChanges();
                return true;
            }
        }
    }
}
