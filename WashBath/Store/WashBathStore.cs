﻿using WashBath.Core.Store;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashBath.Store
{
    public class WashBathStore
    {
        DbContext m_DbContext;

        public void Dispose()
        {
            if (m_DbContext != null)
            {
                m_DbContext.Dispose();
            }
        }

        public DbContext DbContext
        {
            get
            {
                if (m_DbContext == null)
                {
                    m_DbContext = CreateDbContext();
                }
                return m_DbContext;
            }
            set
            {
                m_DbContext = value;
            }
        }

        public virtual DbContext CreateDbContext()
        {
            return new WashBathDbContext();
        }
    }
}
