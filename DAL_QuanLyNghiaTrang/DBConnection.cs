using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLyNghiaTrang
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-E754EJE\\SQLEXPRESS;uid=sa;pwd=123456;database=QuanLyNghiaTrang");
        public object[] excuteProc(string procName, SqlParam[] parameterIn = null, SqlParam[] parameterOut = null)
        {
            object[] data = new object[parameterOut.Length];

            using (SqlCommand cmd = new SqlCommand(procName, con))
            {
                cmd.CommandType = CommandType.Text;

                if (parameterIn != null)
                {
                    for (int i = 0; i < parameterIn.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterIn[i].Name, parameterIn[i].Value);
                    }
                }
                if (parameterOut != null)
                {
                    for (int i = 0; i < parameterOut.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterOut[i].Name, parameterOut[i].Value).Direction = ParameterDirection.Output;
                    }
                }

                Console.WriteLine(cmd.Parameters.Count);

                con.Open();
                cmd.ExecuteNonQuery();
                for (int i = 0; i < parameterOut.Length; i++)
                {
                    data[i] = cmd.Parameters[parameterOut[i].Name].Value;
                }
                con.Close();

            }
            return data;
        }

        public DataTable excuteQuery(string query, SqlParam[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameter[i].Name, parameter[i].Value);
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public class SqlParam
        {
            public string Name;
            public object Value;
            public SqlParam(string name, object value)
            {
                Name = name;
                Value = value;
            }
        }
    }
}
