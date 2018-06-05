using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IDataAccess
/// </summary>
public interface IDataAccess
{
    object GetSingleAnswer(string sql);
    DataTable GetManyRowsCols(string sql);
    int InsertUpdateDelete(string sql);

}