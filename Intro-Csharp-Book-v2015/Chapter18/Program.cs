// See https://aka.ms/new-console-template for more information

using Chapter18;

// Exercise 01
Exercise01.CountNumbers();

// Exercise 02
Exercise02.RemoveOddCountedNumbers();

// Exercise 03
Exercise03.CountWords();

// Exercise 04
var dictHash = new Exercise04.DictHashSet<int>();

// Exercise 05
var doubleDict = new Exercise05.DoubleKeyDictionary<int, string, int>();

// Exercise 06
var multiDict = new Exercise06.MultiValueDictionary<string, string>();

// Exercise 07
var cuckoo = new Exercise07.CuckooHashTable<string, string>();

// Exercise 08
var table = new Exercise08.HashTable<string, int>();

// Exercise 09
var set1 = new Exercise09.HashedSet<int>();
set1.Add(1);
set1.Add(2);
set1.Add(3);

var set2 = new Exercise09.HashedSet<int>();
set2.Add(3);
set2.Add(4);
set2.Add(5);

var union = set1.UnionWith(set2);     // {1, 2, 3, 4, 5}
var inter = set1.IntersectWith(set2); // {3}

Console.WriteLine("Union:");
foreach (var item in union)
    Console.WriteLine(item);

Console.WriteLine("Intersection:");
foreach (var item in inter)
    Console.WriteLine(item);

// Exercise 10
Exercise10.IntersectsAndUnions();

// Exercise 11
var multiset = new Exercise11.TreeMultiSet<int>();

// Exercise 12
Exercise12.BusSchedule();

// Exercise 13
Exercise13.Subsequences();
