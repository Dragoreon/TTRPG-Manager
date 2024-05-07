using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.DBContexts
{
    public class TTRPGManagerDBContextFactory
    {
        private readonly string _connectionString;

        public TTRPGManagerDBContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TtrpgmanagerContext CreateDBContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(_connectionString).Options;
            return new TtrpgmanagerContext(options, _connectionString);
        }
    }
}
