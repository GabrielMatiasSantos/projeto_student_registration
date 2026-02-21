using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_registration
{
    public class ClassSchedule
    {
        private int id;
        private int student;
        private string weekDay;
        private string time;   
        

        public ClassSchedule(int student, string weekDay, string time)
        {
            this.student = student;
            this.weekDay = weekDay;
            this.time = time;
        }

        public ClassSchedule(int id, int student, string weekDay, string time)
        {
            this.id = id;
            this.student = student;
            this.weekDay = weekDay;
            this.time = time;
        }

        public ClassSchedule(string weekDay)
        {
            this.weekDay = weekDay;
        }

        public ClassSchedule(int id)
        {
            this.id = id;
        }


        public int Id
        {
            get { return id; }
        }

        public int Student
        {
            get { return student; }
        }

        public string WeekDay
        {
            get { return weekDay; }
        }

        public string Time
        {
            get { return time; }
        }
    }    
}
