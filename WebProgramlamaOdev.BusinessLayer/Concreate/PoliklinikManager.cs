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
    public class PoliklinikManager:IPoliklinikService
    {
        private readonly IPoliklinikDal _poliklinikDal;

        public PoliklinikManager(IPoliklinikDal poliklinikDal)
        {
            _poliklinikDal = poliklinikDal;
        }

        public void TDelete(Poliklinik t)
        {
           _poliklinikDal.Delete(t);
        }

        public Poliklinik TGetByID(int id)
        {
            return _poliklinikDal.GetByID(id);
        }

        public List<Poliklinik> TGetList()
        {
            return _poliklinikDal.GetList();
        }

        public void TInsert(Poliklinik t)
        {
            _poliklinikDal.Insert(t);
        }

        public void TUpdate(Poliklinik t)
        {
            _poliklinikDal.Update(t);
        }
    }
}
