using ChallengeApp;

Employee employee1 = new Employee("Marek", "Nowak", 42);
Employee employee2 = new Employee("Jan", "Moskal", 30);
Employee employee3 = new Employee("Mariusz", "Dziwny", 51);


employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);

employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(7);

employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(6);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najlepszy wynik osiągnął " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " +
    employeeWithMaxResult.Age + ", a jego wynik to " + maxResult);