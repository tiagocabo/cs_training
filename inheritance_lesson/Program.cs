using System;
using inheritance_lesson;
namespace inheritance_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var new_stack = new Stack();
            new_stack.Push(1);
            new_stack.Push("2");
            new_stack.Pop();

            System.Console.WriteLine(new_stack._elements[0]);
        }
    }
}
