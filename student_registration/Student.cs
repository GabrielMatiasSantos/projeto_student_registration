using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_registration
{
    internal class Student
    {
        private int id;
        private string name;
        private string cpf;
        private string telephone;
        private int day;
        private decimal value;
        private string state;
        private string city;
        private string street;
        private string neighborhood;
        private int number;
        private string zip;
        private string status;


        public Student(string name, string cpf, string telephone, int day, decimal value, string state, string city, string street, string neighborhood, int number, string zip, string status)
        {            
            this.name = name;
            this.cpf = cpf;
            this.telephone = telephone;
            this.day = day;
            this.value = value;
            this.state = state;
            this.city = city;
            this.street = street;
            this.neighborhood = neighborhood;
            this.number = number;
            this.zip = zip;
            this.status = status;
        }

        public Student(int id, string name, string cpf, string telephone, int day, decimal value, string state, string city, string street, string neighborhood, int number, string zip, string status)
        {
            this.id = id;
            this.name = name;
            this.cpf = cpf;
            this.telephone = telephone;
            this.day = day;
            this.value = value;
            this.state = state;
            this.city = city;
            this.street = street;
            this.neighborhood = neighborhood;
            this.number = number;
            this.zip = zip;
            this.status = status;
        }

        public Student(int id)
        {
            this.id = id;
        }


        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Cpf
        {
            get { return cpf; }
        }

        public string Telephone
        {
            get { return telephone; }
        }

        public int Day
        {
            get { return day; }
        }

        public decimal Value
        {
            get { return value; }
        }

        public string State
        {
           get { return state; }
        }

        public string City
        {
            get { return city; }
        }

        public string Street
        {
            get { return street; }
        }

        public string Neighborhood
        {
            get { return neighborhood; }
        }

        public int Number
        {
            get { return number; }
        }

        public string Zip
        {
            get { return zip; }
        }

        public string Status
        {
            get { return status; }
        }
    }
}
