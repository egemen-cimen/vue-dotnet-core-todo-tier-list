﻿using System;
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
            return todoItems.ToArray();
        }

        [HttpPut]
        public int Put(TodoListItem todoListItem)
        {
            todoListItem.Id = todoItems.Count;
            todoItems.Add(todoListItem);
            return todoListItem.Id;
        }

        [HttpPost]
        public bool Post(List<TodoListItem> todoListItems, int id)
        {
            foreach (var a in todoListItems)
            {
                Console.WriteLine(id);
                Console.WriteLine(a.Id + " " + a.Status + " " + a.Text);
            }
            Console.WriteLine("====");
            return true;
        }
    }
}
