using System;
using Priorty_Queue;
using Priorty_Queue.Models;

public class Program
{
    public static void Main()
    {
        /*
        var numbers = new PriorityQueue<string, int>();

        numbers.Enqueue("Sekkiz", 8);
        numbers.Enqueue("Iki", 2);
        numbers.Enqueue("Alti", 6);
        numbers.Enqueue("Dord", 4);

        while (numbers.TryDequeue(out var element, out var priorty))
        {
            Console.WriteLine($"Element: {element} - Priorty: {priorty}");
        }
        */


        var employees = new List<Employee>()
        {
            new Employee("Zulfugar Asgarzade", 23),
            new Employee("Qudrat Abidzade", 21),
            new Employee("Asger Babayev", 22)
        };

        var queue = new PriorityQueue<Employee, Employee>(new EmployeeQueueComparer());


        employees.ForEach(employee => {
            queue.Enqueue(employee, employee);
        });


        while (queue.TryDequeue(out var element, out var priorty))
        {
            Console.WriteLine($"Element: {element} (Age: {element.Age}) - Priorty: {priorty}");
        }

        Console.Read();
    }
}