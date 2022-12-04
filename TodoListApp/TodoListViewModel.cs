using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace TodoListApp
{
     public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItem.Add(new TodoItem("todo 1", false));
            TodoItem.Add(new TodoItem("todo 2", false));
            TodoItem.Add(new TodoItem("todo 3", false));

        }
    }
}
