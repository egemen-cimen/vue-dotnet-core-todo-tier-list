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
            var i = 0;
            var values = Enum.GetValues(typeof(TodoColumn));
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new TodoListItem
            {
                Id = i++,
                Text = "Text_" + i,
                Status = (TodoColumn)values.GetValue(rng.Next(values.Length))
            })
            .ToArray();
        }
    }
}
