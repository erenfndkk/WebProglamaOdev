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
    public class EfDoktorDal : GenericRepository<Doktor>, IDoktorDal
    {

        public EfDoktorDal(Context context) : base(context)
        {
        }
    }
}
