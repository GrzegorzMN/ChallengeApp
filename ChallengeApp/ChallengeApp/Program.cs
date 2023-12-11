using ChallengeApp;

Employee emp1 = new Employee("Jan", "Kowalski", 25);
Employee emp2 = new Employee("Stefan", "Nowak", 35);
Employee emp3 = new Employee("Maria", "Nowacka", 28);

emp1.AddGrade(4);
emp1.AddGrade(9);
emp1.AddGrade(9);
emp1.AddGrade(8);
emp1.AddGrade(3);

emp2.AddGrade(5);
emp2.AddGrade(7);
emp2.AddGrade(9);
emp2.AddGrade(2);
emp2.AddGrade(9);

emp3.AddGrade(9);
emp3.AddGrade(8);
emp3.AddGrade(8);
emp3.AddGrade(2);
emp3.AddGrade(9);

var maxGrade = 0;
var bestEmpCount = 0;
var bestEmployees = "";
Employee? bestEmployee = null;

List<Employee> employees = new()
{
    emp1, emp2, emp3
};

List<Employee> bestEmps = new();

foreach (var emp in employees)
{
    if (emp.TotalGrade > maxGrade)
    {
        bestEmployee = emp;  
        maxGrade = emp.TotalGrade;
        bestEmps.Add(emp);
        bestEmpCount = 1;
        bestEmployees = emp.FirstName + " " + emp.LastName + ", wiek: " + emp.Age;
    }
    else if (emp.TotalGrade == maxGrade)
    {
        bestEmps.Add(emp);
        bestEmpCount++;
        bestEmployees = bestEmployees + ", " + emp.FirstName + " " + emp.LastName + ", wiek: " + emp.Age;
    }
}

if (bestEmpCount == 1)
{ 
    Console.WriteLine("Najlepszy pracownik / pracowniczka to: " + bestEmployees + ", suma ocen:" + maxGrade);
}
else
{
    Console.WriteLine("Najlepsi pracownicy to: " + bestEmployees + ", suma ocen:" + maxGrade);
}