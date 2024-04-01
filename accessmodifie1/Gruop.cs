using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifie1
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private Student[] students;
        public int StudentLimit { get; set; }
        public int StudentCount { get; set; }
        public Group (string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Student[] students = new Student[studentLimit];
            StudentCount = 0;

        }


        public void AddStudent(Student student)
        {
            if (StudentCount < StudentLimit)
            {
                students[StudentCount] = student;
                StudentCount++;
                Console.Write("sagirdleri bu qrupa elve edin", GroupNo);
            }
            else
            {
                Console.Write("group doludur", GroupNo);
            }
        }
        public void DisplayStudents()
        {
            Console.WriteLine("sagirdin oldugu qrupu  {0}:", GroupNo);
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine("Full Name: {0}, Group No: {1}, Avg Point: {2}", students[i].FullName, students[i].GroupNo, students[i].AvgPoint);
            }
        }

        public Student[] SearchStudents(string searchdeyisen)
        {
            Student[] searchResults = new Student[StudentCount];
            int count = 0;
            for (int i = 0; i < StudentCount; i++)
            {
                if (students[i].FullName.Contains(searchdeyisen))
                {
                    searchResults[count] = students[i];
                    count++;
                }
            }
            Array.Resize(ref searchResults, count);
            return searchResults;
        }
    }
}
