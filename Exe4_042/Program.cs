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
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item [" + (i + 1) + "]: " + DEWO[i]);
                }
            }          
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n ***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\n Enter your choice : ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                }
            }
        }
    }
}
