using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_042
{
    class Stack
    {
        private String[] DEWO;
        private int top;
        private int max;
        public Stack()
        {
            DEWO = new String[60];
            top = -1;
            max = DEWO.Length;
        }
        public void push()
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack berlebih");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Masukkan Element: ");
                DEWO[top] = Console.ReadLine();
            }
        }
        public int pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack tidak ada");
                return -1;
            }
            else
            {
                Console.WriteLine("Memunculkan elements: " + DEWO[top]);
                top--;
                return top;
            }
        }
        public void display()
        {
            if(top == -1)
            {
                Console.WriteLine("Stacks is Empty");
                return;
            }
            
        }
        static void Main(string[] args)
        {
        }
    }
}
