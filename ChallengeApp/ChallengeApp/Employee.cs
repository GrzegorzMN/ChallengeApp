namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grade = new();

        public Employee(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
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
        public void AddGrade(int grade)
        {
            this.grade.Add(grade);
        }
    }
}

