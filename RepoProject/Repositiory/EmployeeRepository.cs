using Microsoft.EntityFrameworkCore;
using RepoProject.Data;
using RepoProject.Models;

namespace RepoProject.Repositiory
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) {
            _context = context;
        }
        public void Delete(int EmployeeId)
        {
            Employee employee = _context.employeesss.Find(EmployeeId);
            _context.employeesss.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.employeesss.ToList();
        }

        public Employee GetById(int EmployeeID)
        {
            return _context.employeesss.Find(EmployeeID);
        }

        public void Insert(Employee employee)
        {
           
            _context.employeesss.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Update(Employee employee)
        {
            
            _context.Entry(employee).State = EntityState.Modified;
        }
    }
}
