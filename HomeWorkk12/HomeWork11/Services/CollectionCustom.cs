using HomeWork11.Services.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11.Services
{
    public class CollectionCustom<T> : List<T>
    {
        private List<T> items;

        public CollectionCustom()
        {
            items = new List<T>();
        }

        public int Count()
        {
             return items.Count;
        }

        public void Sorted()
        {
            items.Sort();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void SetDefaultAt(int index)
        {
            RemoveAt(index);
        }

        

    }
}
