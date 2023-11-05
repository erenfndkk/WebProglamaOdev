using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.BusinessLayer.Concreate
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void TDelete(Department t)
        {
            _departmentDal.Delete(t);
        }

        public Department TGetByID(int id)
        {
            return _departmentDal.GetByID(id);
        }

        public List<Department> TGetList()
        {
            return _departmentDal.GetList();
        }

        public void TInsert(Department t)
        {
            _departmentDal.Insert(t);
        }

        public void TUpdate(Department t)
        {
            _departmentDal.Update(t);
        }
    }
}
