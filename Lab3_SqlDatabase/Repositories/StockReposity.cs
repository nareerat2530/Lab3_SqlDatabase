using Lab3_SqlDatabase.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.Repositories
{
    class StockReposity :Repository<Stock>, IStockRepository
    {
        public StockReposity (DbContext context) : base(context)
        {

        }
    }
}
