using System;
using System.Text;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Laboration_2_LinkedList<TypeName> : ILaboration_2_List<TypeName>
    {
        /// <summary>
        /// Describes how a node in the list is constructed.
        /// A node contains:
        /// * Data (of any type) to be stored and handled in the list type
        /// * A reference to the next node in the list.
        /// </summary>
        internal class Node
        {
            internal TypeName Data { get; set; }
            internal Node Next { get; set; }
        }

        private readonly Node first;

        /// <summary>
        /// The constructor creates a dummy node, that acts as sentinel
        /// for the following nodes in the list.
        /// </summary>
        public Laboration_2_LinkedList()
        {
            first = new();
            first.Next = null;
            first.Data = default;
        }
        
        int counter = 0;

        /// <summary>
        /// Inserts (adds) <paramref name="data"/> at the beginning of the list.
        /// This means that all other values are shifted one index towards the end of the list. 
        /// </summary>
        /// <param name="data">The value to be added.</param>
        public void AddFirst(TypeName data)
        {
            Node node = new Node();
            node.Next = first.Next;
            first.Next = node;
            node.Data = data;
            counter++;
        }

        /// <summary>
        /// Traverses the list, and applies the <paramref name="action"/> to each value.
        /// </summary>
        /// <param name="action">The action to be applied.</param>
        public void Iterate(Action<TypeName> action)
        {
            Node node = first.Next; //3
            while (node != null) //n
            {
                action(node.Data); //2
                node = node.Next; //2
            }
        }

        /// <summary>
        /// Appends (adds) <paramref name="data"/> to the end of the list.
        /// </summary>
        /// <param name="data">The value to be added.</param>
        public void AddLast(TypeName data)
        {
            Node node = new Node();
            node.Data = data;
            Node current = first;
            while (current.Next != null) //n
            {
                current = current.Next;
            }
            node.Next = current.Next;
            current.Next = node;
            counter++;
        }

        /// <summary>
        /// Returns the number of values in the list.
        /// </summary>
        /// <returns>The number of nodes in the list.</returns>
        public int Count()
        {
            return counter;
        }

        /// <summary>
        /// Searches for the first occurrence of <paramref name="target"/> in the list>.
        /// </summary>
        /// <param name="target">The value to search for.</param>
        /// <returns>The index of the first occurrence found; or -1 if not found.</returns>
        public int IndexOf(TypeName target)
        {
            Node node = first.Next;
            int index = 0;
            while (node != null)
            {
                if (node.Data.Equals(target))
                {
                    return index;
                }
                node = node.Next;
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Inserts the value <paramref name="data"> at index <paramref name="index"/>.
        /// This means that all other values from (including) <paramref name="index"/> are shifted one 
        /// index towards the end of the list. 
        /// </summary>
        /// <param name="index">Index where <paramref name="data"/> is inserted.</param>
        /// <param name="data">The value to be inserted</param>
        /// <remarks>If <paramref name="index"/> is outside the interval [0, Count()], an <see cref="IndexOutOfRangeException"/> is thrown.</remarks>
        public void Insert(uint index, TypeName data)
        {
            if (index > counter)
            {
                throw new IndexOutOfRangeException();
            }
            Node node = new Node();
            node.Data = data;
            Node current = first;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            node.Next = current.Next;
            current.Next = node;
            counter++;
        }

        /// <summary>
        /// Removes the node at <paramref name="index"/>.
        /// This means that all values from (excluding) <paramref name="index"/> are shifted one 
        /// index towards the beginning of the list. 
        /// </summary>
        /// <param name="index">Index of the element being removed.</param>
        /// <param name="data">The value to be inserted</param>
        /// <remarks>If <paramref name="index"/> is outside the interval [0, Count()], an <see cref="IndexOutOfRangeException"/> is thrown.</remarks>
        public void RemoveAt(uint index)
        {
            if (index > counter)
            {
                throw new IndexOutOfRangeException();
            }
            Node current = first;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            counter--;
        }

        /// <summary>
        /// Makes it possible to use field notation with brackets, as in "myList[i]", to
        /// access the element at index <paramref name="i"/>. 
        /// The accessed element can be both read and written.
        /// </summary>
        /// <param name="i">Index för det värde som du vill få tillgång till</param>
        /// <returns>Det värde som finns på platsen med indexet i</returns>
        /// <remarks>
        /// It is not possible add or remove elements. 
        /// <remarks>If <paramref name="index"/> is outside the interval [0, Count()], an <see cref="IndexOutOfRangeException"/> is thrown.</remarks>
        ///</remarks>
        public TypeName this[uint i] { 
            get 
            {
                Node current = first;
                current = current.Next;
                for (int j = 0; j < i; j++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                Node current = first;
                current = current.Next;
                for (int j = 0; j < i; j++)
                {
                    current = current.Next;
                }
                current.Data = value;
            }
        }
    }
}
