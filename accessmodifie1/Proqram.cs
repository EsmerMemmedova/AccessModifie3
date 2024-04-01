using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace accessmodifie1
{
    internal class Proqram
    { 
        static void Main(string[] args)
        {
            Console.WriteLine(" Yeni qrup yaradaq:");
            string groupNo;
            int studentLimit;
            do
            {
                Console.Write("Group nomresi daxil et: ");
                groupNo = Console.ReadLine();
            } while (groupNo.Length != 5 || !char.IsLetter(groupNo[0]) || !char.IsLetter(groupNo[1]) || !char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]) || !char.IsDigit(groupNo[4]));

            do
            {
                Console.Write("Student limit: ");
                studentLimit = int.Parse(Console.ReadLine());
            } while (studentLimit < 1 || studentLimit > 20);

            Group newGroup = new Group(groupNo, studentLimit);
            Console.WriteLine("Yeni qrup yaradaq: Group No: {0}, Student Limit: {1}", newGroup.GroupNo, newGroup.StudentLimit);

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2. Butun telebelere bax");
                Console.WriteLine("3.Tlebe uzre axtaris et");
                Console.WriteLine("0. proqrami bitir");
                Console.Write("Secimini daxil et: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Telebeye aid detallari daxil et:");
                        Console.Write("Full Name: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Group No: ");
                        string studentGroupNo = Console.ReadLine();
                        Console.Write("Average Point: ");
                        double avgPoint = double.Parse(Console.ReadLine());

                        Student newStudent = new Student(fullName, studentGroupNo, avgPoint);
                        newGroup.AddStudent(newStudent);
                        break;
                    case 2:
                        newGroup.DisplayStudents();
                        break;
                    case 3:
                        Console.Write("daxil et axtardigin deyeri: ");
                        string searchTerm = Console.ReadLine();
                        Student[] searchResults = newGroup.SearchStudents(searchTerm);
                        Console.WriteLine("Search results:");
                        for (int i = 0; i < searchResults.Length; i++)
                        {
                            Console.WriteLine("Full Name: {0}, Group No: {1}, Avg Point: {2}", searchResults[i].FullName, searchResults[i].GroupNo, searchResults[i].AvgPoint);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
