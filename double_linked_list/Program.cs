using System;
namespace double_linked_list
{
    class node
    {
        /*Node class represent the node of doubly linked list
         * It consist of the information part and links to 
         * its succedding and preceeding
         * in terms of next and previous */

        public int noMhs;
        public string name;
        //point to the succeding node
        public node next;
        //point to the preceeding node
        public node prev;
    }
}