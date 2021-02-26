using System;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;

namespace DBConnTestApp
{
    public class IDBConnection
    {
        public static implicit operator IDBConnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator IDBConnection(OracleConnection v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator IDBConnection(OleDbConnection v)
        {
            throw new NotImplementedException();
        }
    }
}