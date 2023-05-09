using System;
using System.Collections.Generic;
using System.Linq;

class CollectionType
{
    public List<string> Strings { get; set; }

    public CollectionType()
    {
        Strings = new List<string>();
    }

    public void AddString(string str)
    {
        Strings.Add(str);
    }

    public IEnumerable<string> FindStringsContaining(string value)
    {
        return Strings.Where(s => s.Contains(value));
    }

    public int CountStringsOfLength(int length)
    {
        return Strings.Count(s => s.Length == length);
    }

    public void SortAscending()
    {
        Strings.Sort();
    }

    public void SortDescending()
    {
        Strings.Sort();
        Strings.Reverse();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CollectionType collection = new CollectionType();
        collection.AddString("apple");
        collection.AddString("banana");
        collection.AddString("cherry");
        collection.AddString("date");
        collection.AddString("fig");

        Console.WriteLine("Введення-виведення:");
        foreach (string str in collection.Strings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nРядки, що містять 'a':");
        foreach (string str in collection.FindStringsContaining("a"))
        {
            Console.WriteLine(str);
        }

        Console.WriteLine($"\nКількість рядків довжини 5: {collection.CountStringsOfLength(5)}");

        collection.SortAscending();
        Console.WriteLine("\nСортування у зростаючому порядку:");
        foreach (string str in collection.Strings)
        {
            Console.WriteLine(str);
        }

        collection.SortDescending();
        Console.WriteLine("\nСортування у спадному порядку:");
        foreach (string str in collection.Strings)
        {
            Console.WriteLine(str);
        }
    }
}
