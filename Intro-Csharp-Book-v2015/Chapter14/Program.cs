// See https://aka.ms/new-console-template for more information

using Chapter14;

Student student = new Student("John B. Mark");
student.Email = "test@email.com";

Library library = new Library("Градска библиотека");

Book book1 = new Book("Под игото", "Иван Вазов", "Народна култура", 1894, "111111");
Book book2 = new Book("Бай Ганьо", "Алеко Константинов", "Хемус", 1895, "222222");
Book book3 = new Book("История славянобългарска", "Паисий Хилендарски", "Манастир", 1762, "333333");

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

Console.WriteLine("\nТърсене на книги от Иван Вазов:");
library.SearchByAuthor("Иван Вазов");

Console.WriteLine("\nПоказване на информация за книга по ISBN:");
library.ShowBookInfo("222222");

Console.WriteLine("\nИзтриване на книга:");
library.RemoveBook("333333");

Console.WriteLine("\nОпит за показване на изтрита книга:");
library.ShowBookInfo("333333");

