// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
