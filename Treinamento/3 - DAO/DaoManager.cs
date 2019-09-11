using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._3___DAO
{
    public class DaoManager
    {
        private SqlConnection _connection = new SqlConnection();
        private SqlTransaction _transaction;

        public void SetConnectionString()
        {
            _connection.ConnectionString = @"user id = sa; password = Nddadm!@#$%;server=tescon20800-1\sql2016;database=MyBank;connection timeout=150";
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }


        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public object ExecuteCommand(string commandText, IEnumerable<SqlParameter> parameters = null)
        {
            try
            {

                OpenConnection();

                SqlCommand command = new SqlCommand { CommandText = commandText, Connection = _connection };

                if (_transaction != null)
                    command.Transaction = _transaction;

                if (parameters != null)
                    foreach (var parameter in parameters)
                        command.Parameters.Add(parameter);

                CloseConnection();
                return command.ExecuteScalar();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataSet SelectRegisters(string commandText, IEnumerable<SqlParameter> parameters)
        {
            var command = new SqlCommand {CommandText = commandText, Connection = _connection};

            if (_transaction != null)
                command.Transaction = _transaction;

            if (parameters != null)
                foreach (var parameter in parameters)
                    command.Parameters.Add(parameter);

            var dataAdapter = new SqlDataAdapter(command);

            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
    }
}
