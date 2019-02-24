﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.UOW
{
    public interface IUnitOfWork :IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
