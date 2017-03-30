using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tute.Domain.Business;
using Tute.Domain.Data;

namespace Tute.BusinessService
{
    public class EmployeeBusinessService : IEmployeeBusinessService
    {
        internal IEmployeeDataRepositary EmpData;

        public EmployeeBusinessService(IEmployeeDataRepositary employeeDataRepositary)
        {
            EmpData = employeeDataRepositary;
        }
        public bool Save(Domain.Model.Employee entity)
        {
            return EmpData.Save(entity);
        }

        public List<Domain.Model.Employee> GetAll()
        {
            return EmpData.GetAll();
        }

        public Domain.Model.Employee GetbyId(long Id)
        {
            return EmpData.GetById(Id);
        }
    }
}
