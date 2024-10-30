using UnitTestCaseDemo.Model;

namespace UnitTestCaseDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 101,
                    Name = "George Harrison",
                    PhoneNo = "11111111111111",
                    EmailId = "george@email.com"
                },
                new Employee()
                {
                    Id = 102,
                    Name = "Amanda Smith",
                    PhoneNo = "222222222222222",
                    EmailId = "george@email.com"
                },
                new Employee()
                {
                    Id = 103,
                    Name = "Usha",
                    PhoneNo = "2222222222222",
                    EmailId = "george@email.com"
                }

            };
        }

        public Employee Add(Employee employee)
        {
            int newId = _employees.Max(x => x.Id) + 1;
            employee.Id = newId;
            _employees.Add(employee);
            return employee;
            //throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var existing = _employees.Find(x => x.Id == id);
            if(existing != null)
            {
                _employees.Remove(existing);
                return true;
            }
            else
                return false;
            //throw new NotImplementedException();
        }

        //public bool Delete(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Employee> GetAll()
        {
            return _employees;
            //throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            return _employees.Where(x=>x.Id == id).FirstOrDefault();
            //throw new NotImplementedException();
        }
    }
}
