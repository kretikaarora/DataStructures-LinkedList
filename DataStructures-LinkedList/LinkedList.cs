// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructures_LinkedList
{   /// <summary>
    /// Creating LinkedList
    /// </summary>
    class LinkedList
    {
        public Node head;
        /// <summary>
        /// Inserting the node at Last
        /// </summary>
        /// <param name="newData"></param>
        public void AppendLast(int newData)
        {
            ///Creating new node to insert at last
            /// if head is null(means not pointing to any node)
            /// then head will point towards this newnode
            /// else we will get the last node 
            /// then make the last node point towards the newnode to attach it 
            Node newNode = new Node(newData);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        /// <summary>
        /// Identifying the last Node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            /// initialising temp to head 
            /// iterating till the temp is pointing towards null to get last node
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

    }
}
