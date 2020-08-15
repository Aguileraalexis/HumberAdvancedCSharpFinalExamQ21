using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace HumberAdvancedCSharpFinalExamQ21
{
    public class MyGenericClass<T> where T: class
    {
        private readonly List<T> data = new List<T>();

        public void Add(T t)
        {
            data.Add(t);
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= data.Count)
                throw new IndexOutOfRangeException();

            return data[index];
        }

        public int Count 
        {
            get { return data.Count; }
        }

        public IEnumerable<T> GetOrderedList()
        {
            return data.OrderByDescending(item => item);
        }

    }

}
