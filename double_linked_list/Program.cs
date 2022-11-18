﻿using System;
namespace double_linked_list
{
    class Node
    {
        /*Node class represent the node of doubly linked list
         * It consist of the information part and links to 
         * its succedding and preceeding
         * in terms of next and previous */

        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        //constructor
        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter rhe roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine);
            Console.Write("\nEnter the name of the student");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }

            /*If the node is to be inserted at between two node*/
            Node previous, current;
            for(current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return ;
                }
            }

            /*On the execution of the above for loop, prev, an current
             * will point to those nodes
             * between which the new node is to be inserted
             */
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;


        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = current = START;
            while (current != null && rollNo != current.noMhs)
            {

                previous = current;
                current = current.next;
            }
            return (current != null);
        }
        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if(Search(rollNo, ref previous, ref current) == false)
                return false;
            //the begining of data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //Node between two nodes in the list
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            /*if the to be deleted is between the list the the following lines of is executed */
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

        public bool listEmpty() {
            if (START == null)
                return true;
            else
                return false;
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecord in the ascending order of" + "Roll number are:\n");
                Node currentnode;
                for (currentnode = START; currentnode != null; currentnode = currentnode.next)
                    Console.Write(currentnode.noMhs + currentnode.name + "\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + currentNode.name + "\n");

            }
        }


    }
}