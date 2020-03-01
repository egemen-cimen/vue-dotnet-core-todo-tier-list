using System;

namespace backend
{
    public class TodoListItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public TodoColumn Status { get; set; }

    }
}
