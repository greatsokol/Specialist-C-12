using System;
using System.Collections;

namespace Lab10
{
    public class Books
    {
        public static Book[] TestBooks => new Book[]
            {
                new Book() {Id=1, Genre="net", Price=32, Author="Seemann", Title="Dependency Injection in .NET" },
                new Book() {Id=2, Genre="lang", Price=42, Author="Richter", Title="CLR via C#" },
                new Book() {Id=3, Genre="tech", Price=21, Author="Munro", Title="ASP.NET MVC 5" },
                new Book() {Id=5, Genre="tech", Price=30, Author="Esposito", Title="Architecting Applications for the Enterprise" },
                new Book() {Id=6, Genre="net", Price=23, Author="Watson", Title="Writing High-Performance .NET Code" },
                new Book() {Id=7, Genre="lang", Price=37, Author="Sharp", Title="Microsoft Visual C# 2013" },
                new Book() {Id=9, Genre="tech", Price=11, Author="Stubblebine", Title="Regular Expression" },
                new Book() {Id=10, Genre="lang", Price=27, Author="Liberty", Title="Learning Visual Basic .Net" },
                new Book() {Id=11, Genre="tech", Price=62, Author="Cwalina", Title="Framework Design Guidelines" },
                new Book() {Id=12, Genre="net", Price=55, Author="Blewett", Title="Pro Asynchronous Programming with .NET" },
                new Book() {Id=13, Genre="tech", Price=47, Author="Nathan", Title="Windows Presentation Foundation Unleashed" },
                new Book() {Id=55, Genre="русские", Price=1, Author="Толстой Лев", Title="Война и Мир" },
                new Book() {Id=55, Genre="русские", Price=2, Author="Толстой Лев", Title="Собрание сочинений" },
            };
    }    
}
