using System;
using Priorty_Queue.Models;

namespace Priorty_Queue
{
    public class EmployeeQueueComparer : IComparer<Employee>
    {
        public int Compare(Employee emp1, Employee emp2)
        {
            if (emp1.Age == emp2.Age)
            {
                return 0;
            }
            else if (emp1.Age < emp2.Age)
            {
                return -1;
            }
            else {
                return 1;
            }

        }
    }
}

