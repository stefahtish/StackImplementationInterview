using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationInterview
{
    class Stack
    {

        private const int MaxSize = 1000;
        private object[] _stack = new object[MaxSize];
        private int _elementIndex = -1;
        public Stack()
        {
        }
        public void Push(object data)
        {
            if (_elementIndex >= MaxSize - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }
            _elementIndex++;
            _stack[_elementIndex] = data;
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No elements in stack");
            }
            object element = _stack[_elementIndex];
            _stack[_elementIndex] = null;
            _elementIndex--;
            return element;
        }
        public object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No elements in stack");
            }
            return _stack[_elementIndex];
        }
        public bool IsEmpty()
        {
            if (_elementIndex < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void PrintStack()
        {
            if (_elementIndex < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = _elementIndex; i >= 0; i--)
                {
                    Console.WriteLine(_stack[i]);
                }
            }
        }
    }
    
}
