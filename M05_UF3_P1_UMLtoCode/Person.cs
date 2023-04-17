using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    public abstract class Person
    {
        public int id;
        public string name;
        protected string phone;
        public string email;
        public Address addres;
    }

    public class Customer : Person
    {
        public DateTime registration;
        private int CreditScore;
        public Account account;
    }

    public class Employee : Person
    {
        public enum department { Department };
        private float Salary;
    }
}
