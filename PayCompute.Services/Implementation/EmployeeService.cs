using PayCompute.Entity;
using PayCompute.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCompute.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext db;
        public EmployeeService(ApplicationDbContext _db)
        {
            db = _db;
        }
        public async Task CreateAsync(Employee newEmployee)
        {
            await db.AddAsync(newEmployee);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int employeeId)
        {
            var employee = GetById(employeeId);
            db.Remove(employee);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAll() => db.Employees.ToList();

        public async Task UpdateAsync(Employee employee)
        {
            db.Update(employee);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var employee = GetById(id);
            db.Update(employee);
            await db.SaveChangesAsync();
        } 

        public Employee GetById(int employeeid) => db.Employees.Where(e => e.Id == employeeid).FirstOrDefault();
        public decimal StudentLoanRepaymentAmount(int id, decimal totalAmount)
        {
            throw new NotImplementedException();
        }

        public decimal UnionFees(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
