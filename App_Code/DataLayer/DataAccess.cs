using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess : IDataAccess
{
    string connStr = ConfigurationManager.ConnectionStrings["XYZDB"].ConnectionString;
    public DataTable GetManyRowsCols(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        DataTable dt = new DataTable();
        try
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }

    public object GetSingleAnswer(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        object obj = null;
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            obj = cmd.ExecuteScalar();
        }
        catch(Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return obj;
    }

    public int InsertUpdateDelete(string sql)
    {
        SqlConnection conn = new SqlConnection(connStr);
        int rowsModified = 0;
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            rowsModified = cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return rowsModified;
    }
}