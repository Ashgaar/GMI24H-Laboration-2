using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Laboration_2_ArrayList<TypeName> : ILaboration_2_List<TypeName>
    {
        private TypeName[] _array = new TypeName[4];
        int counter = 0;
        
        /// <summary>
        /// Inserts (adds) <paramref name="data"/> at the beginning of the list.
        /// This means that all other values are shifted one index towards the end of the list. 
        /// </summary>
        /// <param name="data">The value to be added.</param>
        public void AddFirst(TypeName data)
        {
            if (this.counter == _array.Length)
            {
                ExpandArray();
            }
            TypeName[] temp = new TypeName[_array.Length];
            int index = 0;
            temp[index] = data;
            index++;
            for (int i = 0; i < counter; i++)
            {
                temp[index] = _array[i];
                index++;
            }
            counter++;
            _array = temp;
        }

        //private int _array.Length
        //{
        //    int length = 0;
        //    try
        //    {
        //        for (int i = 0; i < 2147483645; i++)
        //        {
        //            TypeName k = _array[i];
        //            length++;
        //        }
        //    }
        //    catch
        //    {
        //        return length;
        //    }
            
        //    return length;
        //} 
        

        private void ExpandArray()
        {
            var temp = new TypeName[_array.Length * 2];
            int index = 0;
            for (int i = 0; i < counter; i++)
            {
                temp[index] = _array[i];
                index++;
            }
            _array = temp;
        }

        /// <summary>
        /// Traverses the list, and applies the <paramref name="action"/> to each value.
        /// </summary>
        /// <param name="action">The action to be applied.</param>
        public void Iterate(Action<TypeName> action)
        {
            for (int i = 0; i < counter; i++)
            {
                action(_array[i]);
            }
            //foreach (var element in _array)
            //{
            //    action(element);
            //}
        }

        /// <summary>
        /// Appends (adds) <paramref name="data"/> to the end of the list.
        /// </summary>
        /// <param name="data">The value to be added.</param>
        public void AddLast(TypeName data)
        {
            if (counter == _array.Length)
            {
                ExpandArray();
            }
            _array[counter++] = data;
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
        public int IndexOf(TypeName target) {
            int index = 0;

            for (int i = 0; i < counter; i++)
            {
                if (_array[i].Equals(target))
                {
                    index = i;
                    return index;
                }
            }
            //foreach (var element in _array)
            //{
            //    if (element.Equals(target))
            //    {
            //        return index;
            //    }
            //    index++;
            //}
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
            if (index >= 0 && index <= counter)
            {
                if (counter == _array.Length)
                {
                    ExpandArray();
                }
                counter++;
                TypeName[] temp = new TypeName[_array.Length];

                for (int i = 0; i < counter; i++)
                {
                    if (i == index)
                    {
                        temp[i] = data;
                        i++;
                    }
                    if (i != index && i > index)
                    {
                        temp[i] = _array[i - 1];
                    }
                    if( i != index && i < index){
                        temp[i] = _array[i];
                    }
                }
                _array = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
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
            if (index >= 0 && index < counter)
            {
                TypeName[] temp = new TypeName[_array.Length];
                int i = 0;
                int j = 0;
                for (int k = 0; k < counter; k++)
                {
                    if (k != index)
                    {
                        temp[j++] = _array[k];
                    }
                    i++;
                }
                counter--;
                _array = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
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
        public TypeName this[uint i] { get => _array[i]; set => _array[i] = value; }
    }
}

