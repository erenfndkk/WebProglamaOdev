﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.BusinessLayer.Concreate
{
    public class RandevuManager : IRandevuService
    {
        private readonly IRandevuDal _randevuDal;

        public RandevuManager(IRandevuDal randevuDal)
        {
            _randevuDal = randevuDal;
        }

        public void TDelete(Randevu t)
        {
            _randevuDal.Delete(t);
        }

        public Randevu TGetByID(int id)
        {
            return _randevuDal.GetByID(id);
        }

        public List<Randevu> TGetList()
        {
            return _randevuDal.GetList();
        }

        public void TInsert(Randevu t)
        {
            _randevuDal.Insert(t);
        }

        public void TUpdate(Randevu t)
        {
            _randevuDal.Update(t);
        }
    }
}
