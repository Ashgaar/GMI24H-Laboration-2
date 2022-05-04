using LaborationInterfaces;
using Olsson_Mikael;
using System;

namespace ConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Person other = obj as Person; 
            return Name == other?.Name && Age == other?.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return Name + ", " + Age + " år";
        }
    }

    /// <summary>
    /// I klassen Program kan du prova de metoder som du implementerar. Om du vill så sätt gärna upp en ett separat projekt för en testmiljö.
    /// Om du får problem under arbetet så besök gärna handledningstillfällena och diskutera de svårigheter som du har stött på.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Implementera först klassen Laboration_2_LinkedList och kontrollera att den fungerar tillsammans med gränssnittet ILab2List,
            ILaboration_2_List<Person> list = new Laboration_2_LinkedList<Person>();
            

            // När du är klar MyLinkedList, så ta itu med klassen Laboration_2_ArrayList och implementera den på liknande sätt som du gjorde med MyLinkedList.
            //ILab2List<Person> list = new Laboration_2_ArrayList<Person>();

            Person kalle = new Person() { Name = "Kalle", Age = 34 };
            Person jonas = new Person() { Name = "Jonas", Age = 23 };
            Person mikael = new Person() { Name = "Mikael", Age = 21 };
            Person pelle = new Person() { Name = "Pelle", Age = 43 };
            Person karl = new Person() { Name = "Karl", Age = 89 };
            Person sol = new Person() { Name = "Sol", Age = 54 };
            Person lol = new Person() { Name = "Lol", Age = 45 };

            //Console.WriteLine(list.Count());
            //list.AddLast(2);
            //list.AddLast(3);
            //list.AddFirst(1);
            //Console.WriteLine(list[0]);
            //list[0] = 5;
            //Console.WriteLine(list[0]);

            //Console.WriteLine(list.Count());
            //list.Iterate(Console.WriteLine);

            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //list.Count();

            Console.WriteLine("Testing linkedlist");
            Console.WriteLine("-----------------");
            list.AddFirst(kalle);
            Console.WriteLine("Adding Kalle to the start of the list");
            list.AddFirst(jonas);
            Console.WriteLine("Adding Jonas to the start of the list");
            Console.WriteLine("This is how the list currently looks");
            list.Iterate(Console.WriteLine);
            list.AddLast(mikael);
            Console.WriteLine("Adding Mikael to the end of the list");

            Console.WriteLine($"The length of the list is {list.Count()}");
            Console.WriteLine("This is how the list currently looks");
            list.Iterate(Console.WriteLine);

            Console.WriteLine($"Adding Pelle to the start of the list");
            list.AddFirst(pelle);
            Console.WriteLine("This is how the list currently looks");
            list.Iterate(Console.WriteLine);


            Console.WriteLine($"Looking for the index of first occurrence of Mikael");
            Console.WriteLine(list.IndexOf(mikael));

            Console.WriteLine($"Inserting Karl into index 2 (middle)");
            list.Insert(2, karl);
            list.Iterate(Console.WriteLine);


            Console.WriteLine($"Removing index 2 (middle)");
            list.RemoveAt(2);
            list.Iterate(Console.WriteLine);


            Console.WriteLine("Printing out the index 3 in the list");
            Console.WriteLine(list[3]);

            Console.WriteLine("Setting the index 3 to Karl");
            list[3] = karl;
            list.Iterate(Console.WriteLine);



            
            Console.WriteLine();
            Console.WriteLine("Testing ArrayList");
            //Console.WriteLine("-----------------");

            //ILaboration_2_List<Person> arrayList = new Laboration_2_ArrayList<Person>();
            //arrayList.AddFirst(kalle);
            //Console.WriteLine("Adding Kalle to the start of the list");
            //arrayList.AddFirst(jonas);
            //Console.WriteLine("Adding Jonas to the start of the list");
            //Console.WriteLine("This is how the list currently looks");
            //arrayList.Iterate(Console.WriteLine);
            //arrayList.AddLast(mikael);
            //Console.WriteLine("Adding Mikael to the end of the list");

            //Console.WriteLine($"The length of the list is {arrayList.Count()}");
            //Console.WriteLine("This is how the list currently looks");
            //arrayList.Iterate(Console.WriteLine);

            //Console.WriteLine($"Adding Pelle to the start of the list");
            //arrayList.AddFirst(pelle);
            //Console.WriteLine("This is how the list currently looks");
            //arrayList.Iterate(Console.WriteLine);


            //Console.WriteLine($"Looking for the index of first occurrence of Mikael");
            //Console.WriteLine(arrayList.IndexOf(mikael));
            //arrayList.Iterate(Console.WriteLine);
            ////everything above works

            //Console.WriteLine($"Inserting Karl into index 2 (middle)");
            //arrayList.Insert(2, karl);
            //arrayList.Iterate(Console.WriteLine);


            //Console.WriteLine($"Removing index 2 (middle)");
            //arrayList.RemoveAt(2);
            //arrayList.Iterate(Console.WriteLine);


            //Console.WriteLine("Printing out the index 3 in the list");
            //Console.WriteLine(arrayList[3]);

            //Console.WriteLine("This is how the list currently looks");
            //arrayList.Iterate(Console.WriteLine);

            //Console.WriteLine("Setting the index 3 to Karl");
            //arrayList[3] = karl;
            //arrayList.Iterate(Console.WriteLine);
            //arrayList.AddFirst(sol);
            //arrayList.AddFirst(lol);

            //Console.WriteLine("This is how the list currently looks");
            //arrayList.Iterate(Console.WriteLine);
            Console.WriteLine("\nTryck på Enter för att avsluta.");
            Console.ReadLine();
        }
    }
}
