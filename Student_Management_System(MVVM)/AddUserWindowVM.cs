using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.IO;


namespace Student_Management_System_MVVM_
{
    public partial class AddUserWindowVM : ObservableObject

    {
        [ObservableProperty]
        public string? firstname;

        [ObservableProperty]
        public string? lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public int date;

        [ObservableProperty]
        public int year;

        [ObservableProperty]
        public int month;

        [ObservableProperty]
        public string? title;



        [ObservableProperty]
        public BitmapImage selectedimage;


        public Person Student  { get; private set; }

        public Action Close { get; set; }

        public Action CloseAction { get; internal set; }


        public AddUserWindowVM(Person test) {
            Student = test;

            firstname = Student.FirstName;
            lastname = Student.LastName;
            age = Student.Age;
            gpa = Student.Gpa;
            date = Student.Date;
            year = Student.Year;
            month = Student.Month;
            selectedimage = Student.Image;
              
        
        
        
        }

        public AddUserWindowVM()
        {
        }


        [RelayCommand]
        public void Save()
        {



            if (gpa < 0.0 || gpa > 4.0)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error");
                return;
            }
            if (Student == null)
            {

                Student = new Person()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                   Date = date,
                   Year = year,
                   Month = month,
                 

                };


            }
            else
            {

                Student.FirstName = firstname;
                Student.LastName = lastname;
                Student.Age = age;
                Student.Gpa = gpa;
                Student.Image = selectedimage;
                Student.Date = date;
                Student.Year = year;
                Student.Month = month;
               



            }

            if (Student.FirstName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();


        }





        [RelayCommand]
        public void UploadPhoto() { 
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files |*.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == true)
            {
                selectedimage = new BitmapImage(new Uri(dialog.FileName));
                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }


        }





































    }
}
