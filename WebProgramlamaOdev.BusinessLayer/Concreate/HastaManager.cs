using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.EntityFramework;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.BusinessLayer.Concreate
{
    public class HastaManager:IHastaService
    {
        private readonly IHastaDal _hastaDal;

        public HastaManager(IHastaDal hastaDal)
        {
            _hastaDal = hastaDal;
        }

        public void TDelete(Hasta t)
        {
           _hastaDal.Delete(t);
        }

        public Hasta TGetByID(int id)
        {
            return _hastaDal.GetByID(id);
        }

        public List<Hasta> TGetList()
        {
            return _hastaDal.GetList();
        }

        public void TInsert(Hasta t)
        {
            _hastaDal.Insert(t);
        }

        public void TUpdate(Hasta t)
        {
            _hastaDal.Update(t);
        }
    }
}
