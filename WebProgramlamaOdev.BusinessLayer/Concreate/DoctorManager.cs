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
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public void TDelete(Doctor t)
        {
            _doctorDal.Delete(t);
        }

        public Doctor TGetByID(int id)
        {
            return _doctorDal.GetByID(id);
        }

        public List<Doctor> TGetList()
        {
            return _doctorDal.GetList();
        }

        public void TInsert(Doctor t)
        {
            _doctorDal.Insert(t);
        }

        public void TUpdate(Doctor t)
        {
            _doctorDal.Update(t);
        }
    }
}
