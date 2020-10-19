﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private StoreEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public StoreEntities DbContext
        {
            get { return dbContext ?? (dbContext = this.dbFactory.Init()); }
        }

        public void Commit()
        {
            dbContext.Commit();
        }
    }
}
