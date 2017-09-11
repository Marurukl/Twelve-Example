using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Описать класс с несколькими свойствами.
            //    Создать экземпляр класса и инициализировать
            //    его свойства.С помощью рефлексии получить
            //    свойства и их значения из созданного
            //    экземпляра класса. Вывести полученные
            //    значения на экран
            Book book = new Book(123, "English", "Obama", 2500);
            Type myType = book.GetType();
            foreach (var property in myType.GetProperties())
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.GetValue(book));
            }
            Console.ReadLine();
        }
    }
}
