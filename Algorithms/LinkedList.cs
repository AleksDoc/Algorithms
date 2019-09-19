// -----------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="AleksDoc">
// Copyright (c) AleksDoc. 2019. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Algorithms
{
    using System.Collections;
    using System.Collections.Generic;
    using global::Algorithms.Common;

    /// <summary>
    /// Linked list.
    /// </summary>
    /// <typeparam name="T">List data type.</typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Gets an element count.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets or sets the first element in the list.
        /// </summary>
        private Node<T> Head { get; set; }

        /// <summary>
        /// Gets or sets the last element in the list.
        /// </summary>
        private Node<T> Tail { get; set; }

        /// <summary>
        /// Gets a value indicating whether the list is empty.
        /// </summary>
        /// <returns>Returns true if the list is empty</returns>
        public bool IsEmpty() => this.Count == 0;

        /// <summary>
        /// Add a new element to the list.
        /// </summary>
        /// <param name="data">Adding data.</param>
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                this.Tail.Next = node;
            }

            this.Tail = node;
            this.Count++;
        }

        /// <summary>
        /// Remove data from the list.
        /// </summary>
        /// <param name="data">Removing data.</param>
        public void Remove(T data)
        {
            var current = this.Head;

            Node<T> previous = null;
            while (current != null && !current.Data.Equals(data))
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                return;
            }

            if (current.Equals(this.Head))
            {
                this.Head = current.Next;
            }
            else if (current.Equals(this.Tail))
            {
                this.Tail = previous;
                this.Tail.Next = null;
            }
            else
            {
                previous.Next = current.Next;
            }
        }

        /// <summary>
        /// Remove all data from the list.
        /// </summary>
        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = this.Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
