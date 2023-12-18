using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Q1
{
    // Nana Sarpong
    // Final Exam 
    // Write your own MyStack class in a console app that contains a List<int>
    // and implements the three Stack methods:
    // Push(int n), Pop() and Peek() using the List<int>.  
    // Errors - None
    internal class MyStack
    {
        static void Main(string[] args)
        {
            // Create a list to hold integer values
            List<int> numbers = new List<int>();
            // Push these values, representing Stack.Push()
            numbers.Insert(0, 1); 
            numbers.Insert(0, 2);
            numbers.Insert(0, 3);
            numbers.Insert(0, 4);

            Console.WriteLine("Elements with Stack.Push(): ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num); // show the Stack
            }

            Console.WriteLine("Elements with Stack.Pop(): ");
            numbers.Remove(numbers.Count); // Remove the last element in the stack
            foreach (int num in numbers)
            {
                Console.WriteLine(num); // show the new stack
            }

            // peek at the latest element in the new stack
            Console.WriteLine("Elements with Stack.Peek()");
                if (numbers.Count > 0)
                {
                    int topElement = numbers.Count;
                    Console.WriteLine("Top Element (Peek): " + topElement);
                }
                else
                {
                    Console.WriteLine("List is empty");
                }
            }
        }
    }















