using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TTRPG_Manager.DBContexts
{
    public class TTRPGManagerDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TtrpgmanagerContext>
    {
        private string _connectionString;
        public TTRPGManagerDesignTimeDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TtrpgmanagerContext CreateDbConection()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(_connectionString).Options;
            return new TtrpgmanagerContext(options);
        }

        TtrpgmanagerContext IDesignTimeDbContextFactory<TtrpgmanagerContext>.CreateDbContext(string[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}
