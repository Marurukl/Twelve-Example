using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Salary { get; set; }
        public Book(long id , string name , string authorName , int salary)
        {
            Id = id;
            Name = name;
            AuthorName = authorName;
            Salary = salary;
        }
    }
}
