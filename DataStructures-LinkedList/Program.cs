// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructures_LinkedList
{/// <summary>
/// Program Class
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operations on LinkedList");
            LinkedList list = new LinkedList();         
            list.AddSortedElements(56);
            list.AddSortedElements(30);
            list.AddSortedElements(40);
            list.AddSortedElements(70);
            list.Display();
            

        }
    }
}
