using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Data;
using User.Management_Domain.Entities;
using User.Management_Domain.Models;
using User.Management_Domain.Repository;

namespace User.Management_DataAccess.Implementation
{
    public class RoleRepository : GenericRepository<AddUserRole_Request>, IRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public string ConnectionString { get; }

        public RoleRepository(ApplicationDbContext context): base(context) 
        {
            _dbContext = context;
            ConnectionString = _dbContext.Database.GetDbConnection().ConnectionString;

        }

        public IDbConnection Connection { get { return new SqlConnection(ConnectionString); } }

        public override Task<AddUserRole_Request> Add(AddUserRole_Request req)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();

                    var _user = dbConnection.Query<AddUserRole_Request>("SetUserRole_sp",
                        new { UserName = req.UserName, RoleName = req.RoleName },
                        commandType: CommandType.StoredProcedure);
                    dbConnection.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {

                string error = $"Generic Error: {ex.Message}";

            }
            return null;
        }

    }
}
