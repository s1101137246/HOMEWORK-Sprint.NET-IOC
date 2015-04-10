
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id="brown";
            employee1.Name = "熊大";
            employee1.Age = 15;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee1.Id = "Lisa";
            employee1.Name = "麗莎";
            employee1.Age = 20;
            employees.Add(employee2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "brown";
            employees.Name = "熊大";
            employees.Age = 15;

            return employees;
        }

    }
}
