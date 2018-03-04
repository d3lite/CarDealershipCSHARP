using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CarDealershipExample
{
    public class CarDB
    {
        
      

        SqlCommand objCommand = new SqlCommand();
        DBConnect objDB = new DBConnect();

        public DataSet getDistinctCarMake()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getDistinctCarMake";

            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public DataSet getCarModelbyCarMake(string carmake)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getCarModelbyCarMake";

            SqlParameter inputPar = new SqlParameter("@carmake", carmake);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputPar);


            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public DataSet getPackagesbyCarID(string id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getPackagesbyCarID";

            SqlParameter inputPar = new SqlParameter("@carid", id);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputPar);

            return objDB.GetDataSetUsingCmdObj(objCommand);

        }


    }
}