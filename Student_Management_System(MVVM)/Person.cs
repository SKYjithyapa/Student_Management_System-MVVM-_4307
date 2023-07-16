using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Student_Management_System_MVVM_
{
    public class Person
    {
        public int Age { get; set; }

        public int Date { get; set; }

        public int Month { get; set; }

        public int Year { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Gpa { get; set; }

        public BitmapImage Image { get; set; }   

        public string ImageURL { get 
            
            
            { return $"/Image/{Image}"; } 
        
        }

        public Person(int age, int date, int month, int year, string firstName, string lastName, double gpa, BitmapImage image)
        {
            Age = age;
            Date = date;
            Month = month;
            Year = year;
            FirstName = firstName;
            LastName = lastName;
            Gpa = gpa;
            Image = image;
        }

        public Person() { }

    }
}
