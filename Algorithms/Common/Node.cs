// <copyright file="Node.cs" company="AleksDoc">
// Copyright (c) AleksDoc. All rights reserved.
// </copyright>

namespace Algorithms.Common
{
    /// <summary>
    /// Present a node of a linked list.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">Data.</param>
        public Node(T data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        public Node<T> Next { get; set; }
    }
}
