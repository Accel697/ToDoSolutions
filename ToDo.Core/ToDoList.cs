using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Core
{
    public class ToDoList
    {
        private readonly List<ToDoItem> _items = new();

        public IReadOnlyList<ToDoItem> Items => _items.AsReadOnly();

        public ToDoItem Add(string title)
        {
            var item = new ToDoItem(title);
            _items.Add(item);
            return item;
        }

        public bool Remove(Guid id) => _items.RemoveAll(i => i.Id == id) > 0;

        public IEnumerable<ToDoItem> Find(string substring) => _items.Where(i => i.Title.Contains(substring ?? string.Empty, StringComparison.OrdinalIgnoreCase));

        public int Count => _items.Count;
    }
}
