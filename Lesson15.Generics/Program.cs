using System.Linq;

namespace Lesson15.Generics
{
    internal class Program
    {
        public class Stack<T>
        {
            private int index;
            public T[] elements = new T[10];

            public void Push(T item)
            {
                elements[index++] = item;
            }


            public T Pop(T item)
            {
                return elements[--index];
            }

            public T Peek(T item)
            {
                return elements[index - 1];
            }

            public void Clear()
            {

            }

            public int Count
            {
                get { return elements.Count; }
            }

            static void Main(string[] args)
            {
                Stack<int> updatedStack = new Stack<int>();

                updatedStack.Push(5);
                updatedStack.Pop(5);
                updatedStack.Peek(10);
                updatedStack.Clear();
                int countStack = updatedStack.Count;
                Console.WriteLine(countStack);
            }
        }
    }
}