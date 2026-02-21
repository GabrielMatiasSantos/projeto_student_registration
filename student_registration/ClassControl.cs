using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_registration
{
    public class ClassControl
    {
        private int id;
        private int student;
        private DateTime date;
        private string planned;
        private string done;


        public ClassControl(int student, DateTime date, string planned, string done)
        {
            this.student = student;
            this.date = date;
            this.planned = planned;
            this.done = done;
        }

        public ClassControl(int id, int student, DateTime date, string planned, string done)
        {
            this.id = id;
            this.student = student;
            this.date = date;
            this.planned = planned;
            this.done = done;
        }

        public ClassControl(int id)
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

        public DateTime Date
        {
            get { return date; }
        }

        public string Planned
        {
            get { return planned; }
        }

        public string Done
        {
            get { return done; }
        }
    }
}
