using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List liste = new List();
            liste.Olustur();
            Console.Read();
        }
    }
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        public void Olustur()
        {
            Node s = null;
            s = push(s, 10);
            s = push(s, 20);
            //Yazdir(s);
            Console.WriteLine(pop(s));
            s = push(s, 30);
            Console.WriteLine(pop(s));
            Console.WriteLine(pop(s));
        }
        public int pop(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Stack Boş!");
                return -1;
            }
            if (root.next == null)
            {
                int rvalue = root.data;
                return rvalue;
            }
            Node iter = root;
            while(iter.next.next != null)
            {
                iter = iter.next;
            }
            
            Node temp = iter.next;
            int rvalue2 = temp.data;
            iter.next = null;
            return rvalue2;
        }
        public Node push(Node root, int a)
        {
            if(root == null)
            {
                root = new Node();
                root.data = a;
                root.next = null;
                return root;
            }
            Node iter = root;
            while(iter.next != null)
            {
                iter = iter.next;
            }
            Node temp = new Node();
            temp.data = a;
            iter.next = temp;
            temp.next = null;
            return root;
        }
        public void Yazdir(Node root)
        {
            while(root != null)
            {
                Console.WriteLine(root.data);
                root = root.next;
            }
            Console.WriteLine("------");
        }
    }
}
