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
        node START;

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


            
        }
    }
}