using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _Employees = new List<Employee>
        {
            new Employee{ Id = 0, SurName = "Ivanov", FirstName = "Inav", Patronymic = "Ivanovoch", Age = 21},
            new Employee{ Id = 1, SurName = "Sidorov", FirstName = "Sidor", Patronymic = "Sidorovich", Age =32},
            new Employee{ Id = 2, SurName = "Petrov", FirstName = "Petr", Patronymic = "Petrovich", Age = 32}
        };

        public IEnumerable<Employee> GetAll() => _Employees;

        public Employee GetById(int id) => _Employees.FirstOrDefault(e => e.Id == id);

        public void AddNew(Employee employee)
        {
            if(employee is null) throw new ArgumentException(nameof(employee));
            if(_Employees.Contains(employee) || _Employees.Any( e => e.Id == employee.Id)) return;

            employee.Id = _Employees.Count == 0 ? 1 : _Employees.Max(e => e.Id) + 1;
            
            _Employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if(employee is null) return;
            _Employees.Remove(employee);
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}