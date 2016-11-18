using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Homework
{
    class Program
    {
        static int index ;
        static int[] stack;
        static void Main(string[] args)
        {
            int size = 0;
            int toPOP = 0;
            int topush = 0;
            int peek = 0;
            Console.WriteLine("Input size of Stack");
            if (!int.TryParse(Console.ReadLine(), out size) || size<1)
            {
                Console.WriteLine("unsuported expression");
                Console.ReadKey();
                return;
             }
            stack = new int[size];
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Please input next element to be pushed to stack");
                if (!int.TryParse(Console.ReadLine(), out topush))
                {
                    Console.WriteLine("unsuported expression");
                    Console.ReadKey();
                    return;
                }
                Push(topush);
                
            if (i%2==0)
            {
                if (Pop(out toPOP))
                {
                    Console.WriteLine(toPOP+" is poped from stack");
                }
                else
                {
                    Console.WriteLine("stack is empty");
                }
                
            }
            }
            
            // Output for method Peek

          /*  if (Peek(out peek))
            {
                Console.WriteLine("last element in stack is " + peek);
            }
            else
            {
                Console.WriteLine("stack is empty, nothing to peek");
            }*/
         }

        static void Push(int topush)
        {
            if (isFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            stack[index] = topush;
            index++;
        }

        static bool Pop(out int topop)
        {
            index--;
            if (isEmpty())
            {
                index = 0;
                topop = 0;
                return false;
            }

                topop = stack[index];
                return true;
            }

        static bool isFull()
        {
            if (index == stack.Length)
            {
                return true;
            }
            return false;
            
        }

        static bool isEmpty()
        {
            if (index < 0)
            {
                return true;
            }
            return false;
        }
        
        static bool Peek (out int topeek)
        {
            if (index<1)
            {
                topeek = 0;
                return false;
            }

            topeek = stack[index-1];
            return true;
        }
    }
}
