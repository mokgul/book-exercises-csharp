// See https://aka.ms/new-console-template for more information

using Chapter16;

// Exercise 01
//Exercise01.ListSum();

// Exercise 02
//Exercise02.NumbersStack(5);

// Exercise 03
//Exercise03.SortNumbers();

// Exercise 04
Exercise04.FindLongestSubSequence();

// Exercise 05
Exercise05.RemoveNegativeNumbers();

// Exercise 06
Exercise06.RemoveOddCountedNumbers();

// Exercise 07
Exercise07.CountOccurrence();

// Exercise 08
Exercise08.FindMajorant();

// Exercise 09
Exercise09.PrintSequence(2);

// Exercise 10
Exercise10.Operations(4, 20);

// Exercise 11
Exercise11.DoublyLinkedList<int> list = new();
list.AddLast(10);
list.AddLast(20);
list.AddFirst(5);
list.InsertAt(1, 7); // 5, 7, 10, 20

Console.WriteLine(string.Join(", ", list.ToArray())); // 5, 7, 10, 20
Console.WriteLine("Contains 10: " + list.Contains(10)); // true
list.RemoveAt(2); // премахва 10
Console.WriteLine(string.Join(", ", list.ToArray())); // 5, 7, 20

// Exercise 12
Exercise12.DynamicStack<int> stack = new();
stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine(stack.Peek());            // 30
Console.WriteLine(stack.Pop());             // 30
Console.WriteLine(string.Join(", ", stack.ToArray())); // 20, 10

// Exercise 13
Exercise13.StrictDeque<string> deque = new();
deque.AddLeft("a");
deque.AddRight("b");
deque.AddRight("c");
deque.AddLeft("d");

Console.WriteLine(deque.RemoveLeft()); // d
Console.WriteLine(deque.RemoveRight()); // c

// Exercise 14
Exercise14.CircularQueue<int> queue = new();
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);
Console.WriteLine(queue.Peek());    // 10
Console.WriteLine(queue.Dequeue()); // 10
Console.WriteLine(queue.Dequeue()); // 20
queue.Enqueue(40);
queue.Enqueue(50);
queue.Enqueue(60); // Автоматично удвояване
Console.WriteLine(queue.Dequeue()); // 30

// Exercise 15
var listLinked = new Exercise15.LinkedList();
listLinked.Add(5);
listLinked.Add(3);
listLinked.Add(8);
listLinked.Add(1);

Console.WriteLine("Before sort:");
listLinked.Print();

listLinked.Sort();

Console.WriteLine("After sort:");
listLinked.Print();
