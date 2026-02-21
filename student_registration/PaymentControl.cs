using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_registration
{
    public class PaymentControl
    {
        private int id;
        private int[] student;
        private DateTime date;
        private string status;


        public PaymentControl()
        {
            Student = default;
            Date = default;
            Status = default;
        }

        public PaymentControl(int id, string status)
        {
            this.id = id;
            this.status = status;
        }
        
        public int Id
        {
            get { return id; }
        }

        public int[] Student
        {
            get { return student; }
            set { student = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
