﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grade = new();

        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public int TotalGrade
        {
            get
            {
                return this.grade.Sum();
            }
        }
        public void AddGrade(int gr)
        {
            this.grade.Add(gr);
        }
    }
}

