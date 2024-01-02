using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EmployeeAbstract : MonoBehaviour
{
    public static string companyName = "SvindomGames";
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}
