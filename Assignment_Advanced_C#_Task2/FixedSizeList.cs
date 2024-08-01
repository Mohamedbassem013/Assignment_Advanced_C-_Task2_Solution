using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task2
{
    public class FixedSizeList<T>
    {
        private readonly List<T> _items;
        private readonly int _capacity;

        public FixedSizeList(int capacity)
        {
            if (capacity > 0)
            {
                _capacity = capacity;
                _items = new List<T>(capacity);
            }
            else
            {
                Console.WriteLine("Capacity must be greater than zero.");
            }
        }

        public int GetItemCount() { return _items.Count; }
        public int GetCapacity() { return _capacity; }

        public void Add(T item)
        {
            if (_items.Count < _capacity)
            {
                _items.Add(item);
            }
            else
            {
                Console.WriteLine("List has reached its capacity.");
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                return _items[index];
            }
            else
            {
                Console.WriteLine("Index is out of range.");
                return default(T);
            }
        }
    }
}
