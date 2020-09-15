using System.Collections.Generic;
namespace inheritance_lesson
{
    public class Stack
    {
        public List<object> _elements = new List<object>();
        public void Push(object element)
        {
            System.Console.WriteLine("Push");

            _elements.Add(element);
        }

        public object Pop()
        {
            System.Console.WriteLine("Poping...");
            if (_elements.Count > 1)
            {
                            _elements.RemoveRange(0, _elements.Count-1);

            }
            else
            {
                System.Console.WriteLine("Not enough elements to pop");
            }
            return (object) _elements;
        }

        public void Clear()
        {
            System.Console.WriteLine("clear");
        }
    }
}
