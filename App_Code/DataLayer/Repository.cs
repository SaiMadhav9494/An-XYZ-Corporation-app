using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Repository
/// </summary>
public class Repository : IRepositoryAuthentication
{
    IDataAccess _idac = null;

    public Repository()
    {
        _idac = new DataAccess();
    }

    public Repository(IDataAccess idac)
    {
        _idac = idac;
    }
    public bool VerifyLogin(string uname, string pwd)
    {


        bool ret = false;
        try
        {
            string sql = "select Username from Users where " +
                "Username='" + uname + "' and Password='" +
                pwd + "'";
            object obj = _idac.GetSingleAnswer(sql);
            if (obj != null)
                ret = true;
        }
        catch(Exception)
        {
            throw;
        }
        return ret;
    }
}