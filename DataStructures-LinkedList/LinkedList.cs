﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualBasic;
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
        /// UC1,UC3
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
        /// UC1,UC3
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

        /// <summary>
        /// Inserting in the begining 
        /// UC2
        /// </summary>
        /// <param name="newData"></param>
        public void AppendFirst(int newData)
        {
            ///Creating a new node
            ///if node is empty initailising the new node to head
            ///Pointing the new node where head is pointing 
            ///then making the head point towards new node 
            ///we cant reverse the above two order          
            Node newNode = new Node(newData);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
        }

        /// <summary>
        /// displaying the Linked List
        /// </summary>
        public void Display()
        {
            ///we initialise this temp so that head remains the same 
            ///if temp is poining towards null list is empty
            ///otherwise we need to move temp till it points null 
            ///display all the values simultaneously 
            Node temp = this.head;
            if (temp.next == null)
            {
                Console.WriteLine("Nothing to display");
                return;
            }
            else
            {
                Console.WriteLine("The values in LinkedList is ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        /// <summary>
        /// Inserting data in between nodes
        /// UC4
        /// </summary>
        /// <param name="newData"></param>
        public void InsertInBetween(int newData)
        {
            ///Creating a new node
            ///Iterating temp till it reaches the node after which you want to insert
            ///Creating a link with that node
            Console.WriteLine("Insert the node data you want insert after");
            int addData = Convert.ToInt32(Console.ReadLine());
            Node newNode = new Node(newData);
            Node temp = this.head;
            while (temp.data!=addData)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;

        }

        /// <summary>
        /// Removing the first element 
        /// UC5
        /// </summary>
        public void Pop()
        {
            ///removing the element by shifting the head
            if(this.head==null)
            {
                Console.WriteLine("no element found , linkedlist is empty");
            }
            Console.WriteLine("the element poped out is {0}",head.data);
            this.head = this.head.next;
        }
    }
}
