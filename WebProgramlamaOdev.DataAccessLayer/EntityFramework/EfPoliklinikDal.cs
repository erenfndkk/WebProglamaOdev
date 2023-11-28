﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.Repositories;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.DataAccessLayer.EntityFramework
{
    public class EfPoliklinikDal : GenericRepository<Poliklinik>, IPoliklinikDal
    {
        public EfPoliklinikDal(Context context) : base(context)
        {
        }
    }
}
