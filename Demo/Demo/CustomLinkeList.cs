﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CustomLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CustomLinkedList()
        {
            size = 0;
        }
        public class Node
        {
            public int Value;
            public Node Next;

            public Node(int Value)
            {
                this.Value = Value;
            }
        }

        public void insertFirst(int Value)
        {
            Node node = new Node(Value);
            node.Next = head;
            head = node;

            if (tail == null)
            {
                tail = node;
            }
            size++;
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write("{0}" + "-> ", temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("Null\n");
        }
    }
}
