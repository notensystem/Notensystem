using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Notensystem.Core;

namespace Notensystem.DataAccess
{
    public class MySqlWrapper
    {
        private MySqlConnection connection;

        public DatabaseConnection DatabaseConnection { get; private set; }

        public ConnectionState ConnectionState
        {
            get { return connection.State; }
        }

        public MySqlWrapper(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;

            connection = new MySqlConnection(DatabaseConnection.ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                throw new DatabaseException(ApplicationEnvironment.GetString("ConnectionFailed"));
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                //throw new DatabaseException(ApplicationEnvironment.GetString("ConnectionFailed"));
            }
        }

        public void ExecuteScript(string script)
        {
            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                MySqlCommand command = new MySqlCommand(script, connection, transaction);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw new DatabaseException(ApplicationEnvironment.GetString("ConnectionFailed"));
            }
        }

        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                transaction.Commit();
                return reader;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
