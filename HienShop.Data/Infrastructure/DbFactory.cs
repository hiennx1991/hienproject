using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HienShopDbContext dbContext;

        public HienShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HienShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
