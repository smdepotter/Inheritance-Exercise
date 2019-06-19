using System;
using System.Collections.Generic;

namespace Inheritance_Exercise
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can't add nothing.");

            _list.Add(obj);
        }

        public object Pop()
        {
            var index = _list.Count - 1;

            if (_list.Count == 0)
                throw new InvalidOperationException("You can't pop an empty stack.");

            var obj = _list[index];
            _list.RemoveAt(index);
            return obj;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}