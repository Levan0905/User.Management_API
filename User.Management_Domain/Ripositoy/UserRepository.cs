using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Entities;
using User.Management_Domain.Repository;
using User.Management_Domain.Data;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http.HttpResults;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace User.Management_DataAccess.Implementation
{
    public class UserRepository: GenericRepository<Management_Domain.Entities.User>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public string ConnectionString { get; }

        public UserRepository(ApplicationDbContext context): base(context)
        {
            _dbContext = context;
            ConnectionString = _dbContext.Database.GetDbConnection().ConnectionString;
            
        }

        public IDbConnection Connection { get { return new SqlConnection(ConnectionString); } }

        public override Task<Management_Domain.Entities.User> Add(Management_Domain.Entities.User user)
        {
            try 
            {
                using (IDbConnection dbConnection = Connection) 
                { 
                    dbConnection.Open();
                    
                    var _user = dbConnection.Query<Management_Domain.Entities.User>("CreateUser_sp", 
                        new {id = user.Id,FirstName = user.FirstName,LastName = user.LastName,UserName = user.UserName,Password = user.Password,Email=user.Email },
                        commandType:CommandType.StoredProcedure);
                    dbConnection.Close();
                    return null;
                }

            } 
            catch(Exception ex) 
            {

                string error= $"Generic Error: {ex.Message}";
            
            }
            return null;
        }

        public override Task<Management_Domain.Entities.User> Update(Management_Domain.Entities.User user)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();

                    var _user = dbConnection.Query<Management_Domain.Entities.User>("UpdateUser_sp",
                        new { id = user.Id, FirstName = user.FirstName, LastName = user.LastName, UserName = user.UserName, Password = user.Password, Email = user.Email },
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

        public override Task<Management_Domain.Entities.User> Get(Management_Domain.Entities.User user)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();

                    var _user = dbConnection.Query<Management_Domain.Entities.User>("GetUserByRole_sp",
                        new { id = user.Id, FirstName = user.FirstName, LastName = user.LastName, UserName = user.UserName, Password = user.Password, Email = user.Email },
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
