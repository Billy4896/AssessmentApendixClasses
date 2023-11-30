using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitSoln
{
    /// <summary>
    /// Doubly linked list implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        /// <summary>
        /// Gets or sets the head (first node) of the linked list.
        /// </summary>
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the tail (last node) of the linked list.
        /// </summary>
        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds a new node with the specified value at the beginning of the linked list.
        /// </summary>
        /// <param name="value">The value to be added.</param>
        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }


        /// <summary>
        /// Adds the provided node at the beginning of the linked list.
        /// </summary>
        /// <param name="node">The node to be added.</param>
        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }

            Count++;
        }

        /// <summary>
        /// Adds a new node with the specified value at the end of the linked list.
        /// </summary>
        /// <param name="value">The value to be added.</param>
        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }


        /// <summary>
        /// Adds the provided node at the end of the linked list.
        /// </summary>
        /// <param name="node">The node to be added.</param>
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }

        /// <summary>
        /// Removes the first node from the linked list.
        /// </summary>
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        /// <summary>
        /// Removes the last node from the linked list.
        /// </summary>
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        /// <summary>
        /// Gets the number of elements in the linked list.
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds an item to the linked list.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void Add(T item)
        {
            AddFirst(item);
        }

        /// <summary>
        /// Determines whether the doubly linked list contains a specific item.
        /// </summary>
        /// <param name="item">The item to locate in the linked list.</param>
        /// <returns>
        /// True if the item is found in the linked list; else, false.
        /// </returns>
        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Copies the elements of the linked list to an array, starting at a particular index.
        /// </summary>
        /// <param name="array">The array where the elements copied from the linked list.</param>
        /// <param name="arrayIndex">The index in the array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the linked list is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Removes the first occurrence of a specific item from the linked list.
        /// </summary>
        /// <param name="item">The item to remove from the linked list.</param>
        /// <returns>
        /// True if the item is successfully removed; else, false.
        /// </returns>
        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the linked list.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the linked list.
        /// </returns>
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Returns a non-generic enumerator that iterates through the linked list.
        /// </summary>
        /// <returns>
        /// A non-generic enumerator that can be used to iterate through the linked list.
        /// </returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        /// <summary>
        /// Removes all nodes from the linked list.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
