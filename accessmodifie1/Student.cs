﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifie1
{
    internal class Student
    {

        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public double AvgPoint { get; set; }

        public Student(string fullName, string groupNo, double avgPoint)
        {
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }
    }
}
