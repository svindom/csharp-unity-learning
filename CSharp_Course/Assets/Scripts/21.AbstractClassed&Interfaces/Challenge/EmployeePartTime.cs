public class EmployeePartTime : EmployeeAbstract
{
    public int hoursWorked;
    public int hourlyRate;
    public override void CalculateMonthlySalary() 
    {
        int total = 0;
        total = hoursWorked * hourlyRate;
    }
}