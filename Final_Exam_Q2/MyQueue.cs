using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Q2
{
    internal class MyQueue
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(12);
            numbers.Add(3);
            numbers.Add(5);

            Console.WriteLine("Enqueued Numbers");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            int dequeuedNumbers = numbers[numbers.Count - 1];

            numbers.RemoveAt(numbers.Count - 1); // Remove the last element

            // Displaying the "popped" element and updated list
            Console.WriteLine("Popped Element: " + dequeuedNumbers);
            Console.WriteLine("List elements after 'Dequeue':");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // peek at the front element in the new stack
            if (numbers.Count > 0)
            {
                int frontElement = numbers[4];
                Console.WriteLine("Front Element (Peek): " + frontElement);
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }
    }
}
