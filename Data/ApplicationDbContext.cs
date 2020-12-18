using DragonFin_API.Models;
using Finportal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Finportal.Data
{
    /// <summary>
    /// Where to get the data from
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        /// <summary>
        /// Gets the function from pgAdmin db
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        #region Household
        public List<Household> GetAllHouseholds(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allHouseholds = new List<Household>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallhouseholds", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allHouseholds.AddRange((List<Household>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Household>)));
                    }
                }
                connString.Close();
            }
            return allHouseholds;
        }
        #endregion

        #region Users
        public List<FPUser> GetAllUsers(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allUsers = new List<FPUser>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallusers", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allUsers.AddRange((List<FPUser>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<FPUser>)));
                    }
                }
                connString.Close();
            }
            return allUsers;
        }
        #endregion

        #region Bank Account
        public List<BankAccount> GetAllBankAccounts(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allBankAccounts = new List<BankAccount>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getbankaccounts", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allBankAccounts.AddRange((List<BankAccount>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<BankAccount>)));
                    }
                }
                connString.Close();
            }
            return allBankAccounts;
        }
        #endregion

        #region Categories
        public List<Category> GetAllCategories(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allCategories = new List<Category>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallcategories", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allCategories.AddRange((List<Category>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Category>)));
                    }
                }
                connString.Close();
            }
            return allCategories;
        }
        #endregion

        #region Category Items
        public List<CategoryItem> GetAllCategoryItems(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allCategoryItems = new List<CategoryItem>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallcategoryitems", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allCategoryItems.AddRange((List<CategoryItem>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<CategoryItem>)));
                    }
                }
                connString.Close();
            }
            return allCategoryItems;
        }
        #endregion

        #region Invitations
        public List<Invitation> GetAllInvitations(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allInvitations = new List<Invitation>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallinvitations", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allInvitations.AddRange((List<Invitation>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Invitation>)));
                    }
                }
                connString.Close();
            }
            return allInvitations;
        }
        #endregion

        #region Notifications
        public List<Notification> GetAllNotifications(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allNotifications = new List<Notification>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallnotifications", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allNotifications.AddRange((List<Notification>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Notification>)));
                    }
                }
                connString.Close();
            }
            return allNotifications;
        }
        #endregion

        #region Transactions
        public List<Transaction> GetAllTransactions(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allTransactions = new List<Transaction>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getalltransactions", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allTransactions.AddRange((List<Transaction>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Transaction>)));
                    }
                }
                connString.Close();
            }
            return allTransactions;
        }
        #endregion

        #region Attachments
        public List<Attachment> GetAllAttachments(IConfiguration configuration)
        {
            //1. OPen connection string
            var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            //2. Need an empty List<FPUser> in case there aren't any in the DB
            var allAttachments = new List<Attachment>();

            //3. This is where npgsql what function to call
            using (var cmd = new NpgsqlCommand("getallattachments", connString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //4. wehre it is called and the data is stored into an NpgsqlDataBase
                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allAttachments.AddRange((List<Attachment>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Attachment>)));
                    }
                }
                connString.Close();
            }
            return allAttachments;
        }
        #endregion


    }
}
