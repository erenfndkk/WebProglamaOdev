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
    public class DoktorManager:IDoktorService
    {
        private readonly IDoktorDal _doktorDal;

        public DoktorManager(IDoktorDal doktorDal)
        {
            _doktorDal = doktorDal;
        }

        public void TDelete(Doktor t)
        {
            _doktorDal.Delete(t);
        }

        public Doktor TGetByID(int id)
        {
            return _doktorDal.GetByID(id);
        }

        public List<Doktor> TGetList()
        {
           return _doktorDal.GetList();
        }

        public void TInsert(Doktor t)
        {
            _doktorDal.Insert(t);
        }

        public void TUpdate(Doktor t)
        {
            _doktorDal.Update(t);
        }
    }
}
