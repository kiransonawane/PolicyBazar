using System;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace CleanArch.Test.Helper
{
    public static class TestConstants
    {
        public static SqlException GetSqlException()
        {
            var sqlException = FormatterServices.GetUninitializedObject(typeof(SqlException)) as SqlException;

            return sqlException;
        }

        public static Exception GetGeneralException()
        {
            return new Exception("Test Exception");
        }

      
    }
}
