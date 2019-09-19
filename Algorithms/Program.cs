// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="AleksDoc">
// Copyright (c) AleksDoc. 2019. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Linq;

    /// <summary>
    /// Contents the entry method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of an application.
        /// </summary>
        private static void Main()
        {
            var linkedList = new LinkedList<int>();

            var testData = new[] { 2, 4, 6, 8 };
            testData.ToList().ForEach(n => linkedList.Add(n));

            LogListData(linkedList);

            var removingData = 4;
            linkedList.Remove(removingData);

            Console.WriteLine($"\nRemoved the value {removingData}");
            LogListData(linkedList);
        }

        private static void LogListData<T>(LinkedList<T> linkedList)
        {
            Console.WriteLine("\nLinkedList Data:");
            linkedList.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
