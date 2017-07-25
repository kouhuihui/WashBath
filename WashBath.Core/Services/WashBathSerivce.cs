using WashBath.Core.Store;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashBath.Core.Services
{
   public class WashBathSerivce: IDisposable
    {
        protected DbContext m_DbContext;

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
                    m_DbContext = new WashBathDbContext();
                }

                return m_DbContext;
            }
            set
            {
                m_DbContext = value;
            }
        }
    }
}
