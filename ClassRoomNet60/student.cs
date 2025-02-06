using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class student
    {
        public string Name { get; set; }
        public int BirthMonth {  get; set; }
        public int Birthday { get; set; }

        public student(string name, int birthmonth, int birthday) 
        {
            Name = name;
            BirthMonth = birthmonth;
            Birthday = birthday;
            


        }
}
}

