using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Management_System_MVVM_
{
    public partial class MainWindowVM : ObservableObject

    {


        [ObservableProperty]
        public ObservableCollection<Person> students;

        [ObservableProperty]
        public Person selectedperson;

       


        [RelayCommand]
        public void AddUserCommand()
        {
            var add = new AddUserWindowVM();
            
            AddUserWindow window = new AddUserWindow(add);
            window.ShowDialog();

            if (add.Student != null)
            {
                Students.Add(add.Student);

            }


        }
        [RelayCommand]
        public void RemoveUserCommand()
        {

            if (Selectedperson != null)
            {
                string name = Selectedperson.FirstName;
                Students.Remove(Selectedperson);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }

            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }



        }

        [RelayCommand]
        public void EditUserCommand()
        {
            if (Selectedperson != null)
            {
                var add = new AddUserWindowVM(Selectedperson);
               

                var window = new AddUserWindow(add);
                window.ShowDialog();

                int indx = Students.IndexOf(Selectedperson);
                Students.RemoveAt(indx);
                Students.Insert(indx, add.Student);
            }


            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        [RelayCommand]
        public void ExitCommand() {


        }


        public MainWindowVM()
        {
           
            Students = new ObservableCollection<Person>();
            BitmapImage image1 = new BitmapImage(new Uri("/Image/1.png", UriKind.Relative));
            BitmapImage image2 = new BitmapImage(new Uri("/Image/2.png", UriKind.Relative));
            BitmapImage image3 = new BitmapImage(new Uri("/Image/3.png", UriKind.Relative));
            BitmapImage image4 = new BitmapImage(new Uri("/Image/4.png", UriKind.Relative));
            BitmapImage image5 = new BitmapImage(new Uri("/Image/5.png", UriKind.Relative));
            BitmapImage image6 = new BitmapImage(new Uri("/Image/6.png", UriKind.Relative));
            BitmapImage image7 = new BitmapImage(new Uri("/Image/7.png", UriKind.Relative));
           
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32,image1));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image2));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image3));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image4));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image5));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image6));
            Students.Add(new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32, image7));




        }



        [RelayCommand]
        public void AddPersoncommand()
        {
            BitmapImage image7 = new BitmapImage(new Uri("/Image/7.png", UriKind.Relative));
            var person2 = new Person(12, 32, 43, 32, "Srijith", "Yaparathna", 32,image7);
            Students.Add(person2);

        }









    }
}