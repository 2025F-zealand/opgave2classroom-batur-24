using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public Student(string Name, int BirthMonth, int BirthDay)
        {
            Name = Name;
            BirthMonth = BirthMonth; 
            BirthDay = BirthDay; 
        
        }
        
    }
}
