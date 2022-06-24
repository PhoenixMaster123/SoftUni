using System;
using System.Collections.Generic;
using System.Text;

namespace _1.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> collection;

        private int currentIndex;

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currentIndex = 0;
        }

        public List<T> List => collection;

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currentIndex++;
            }

            return canMove;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine($"{collection[currentIndex]}");
        }

        public bool HasNext() => currentIndex < collection.Count - 1;
    }
}
