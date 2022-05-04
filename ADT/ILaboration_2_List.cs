using System;

namespace LaborationInterfaces
{
    /// <summary>
    /// Defines a list of with a sequence of elements, of type <typeparamref name="TypeName"/>. 
    /// Every element has an index in the range [0, i]. 
    /// The list contains one and only one element for each index in the range [0, i].
    /// The number of elements is i-1, and is returned by Count().
    /// Elements can be inserted (added) at the beginning of the list, at the end of the list, 
    /// or at any index.
    /// It is possible to iterate over the list, and to reach an element at a specific index using 
    /// field notation, i.e. "myList[n]".
    /// </summary>
    /// <typeparam name="TypeName"></typeparam>
    public interface ILaboration_2_List<TypeName>
    {


        /// <summary>
        /// Inserts (adds) <paramref name="data"/> at the beginning of the list.
        /// This means that all other values are shifted one index towards the end of the list. 
        /// </summary>
        /// <param name="data">The value to be added.</param>

        void AddFirst(TypeName data);

        /// <summary>
        /// Traverses the list, and applies the <paramref name="action"/> to each value.
        /// </summary>
        /// <param name="action">The action to be applied.</param>
        void Iterate(Action<TypeName> action);

        /// <summary>
        /// Appends (adds) <paramref name="data"/> to the end of the list.
        /// </summary>
        /// <param name="data">The value to be added.</param>
        void AddLast(TypeName data);

        /// <summary>
        /// Returns the number of values in the list.
        /// </summary>
        /// <returns>The number of nodes in the list.</returns>
        int Count();

        /// <summary>
        /// Searches for the first occurrence of <paramref name="target"/> in the list>.
        /// </summary>
        /// <param name="target">The value to search for.</param>
        /// <returns>The index of the first occurrence found; or -1 if not found.</returns>
        int IndexOf(TypeName target);

        /// <summary>
        /// Inserts the value <paramref name="data"> at index <paramref name="index"/>.
        /// This means that all other values from (including) <paramref name="index"/> are shifted one 
        /// index towards the end of the list. 
        /// </summary>
        /// <param name="index">Index where <paramref name="data"/> is inserted.</param>
        /// <param name="data">The value to be inserted</param>
        /// <remarks>If <paramref name="index"/> is outside the interval [0, Count()], an <see cref="IndexOutOfRangeException"/> is thrown.</remarks>
        void Insert(uint index, TypeName data);

        /// <summary>
        /// Removes the node at <paramref name="index"/>.
        /// This means that all values from (excluding) <paramref name="index"/> are shifted one 
        /// index towards the beginning of the list. 
        /// </summary>
        /// <param name="index">Index of the element being removed.</param>
        /// <param name="data">The value to be inserted</param>
        /// <remarks>If <paramref name="index"/> is outside the interval [0, Count()], an <see cref="IndexOutOfRangeException"/> is thrown.</remarks>
        void RemoveAt(uint index);

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
        
        // Mer information om indexerare finns på följande adress:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        TypeName this[uint i] { get; set; }

    }
}
