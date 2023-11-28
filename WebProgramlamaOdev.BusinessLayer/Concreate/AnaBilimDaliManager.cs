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
    public class AnaBilimDaliManager:IAnaBilimDaliService
    {
        private readonly IAnaBilimDaliDal _anaBilimDaliDal;

        public AnaBilimDaliManager(IAnaBilimDaliDal anaBilimDaliDal)
        {
            _anaBilimDaliDal = anaBilimDaliDal;
        }

        public void TDelete(AnaBilimDali t)
        {
            _anaBilimDaliDal.Delete(t);
        }

        public AnaBilimDali TGetByID(int id)
        {
            return _anaBilimDaliDal.GetByID(id);
        }

        public List<AnaBilimDali> TGetList()
        {
            return _anaBilimDaliDal.GetList();
        }

        public void TInsert(AnaBilimDali t)
        {
            _anaBilimDaliDal.Insert(t);
        }

        public void TUpdate(AnaBilimDali t)
        {
            _anaBilimDaliDal.Update(t);
        }
    }
}
