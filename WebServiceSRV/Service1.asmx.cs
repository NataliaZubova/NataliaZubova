using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Services;
using System.Data.OracleClient;

namespace WebServiceSRV
{
    /// <summary>
    /// Сводное описание для Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet SRV(string ФИО, string Паспорт)
        {
            SqlConnection MyConnection = new SqlConnection("Server=filial;database=Гибдд;uid=nata;pwd=123");
            SqlDataAdapter myData = new SqlDataAdapter("Shtraf", MyConnection);
            myData.SelectCommand.CommandType = CommandType.StoredProcedure;
            myData.SelectCommand.Parameters.Add(new SqlParameter("@ФИО", SqlDbType.Char, 40));
            myData.SelectCommand.Parameters.Add(new SqlParameter("@Паспорт", SqlDbType.Char, 10));
            myData.SelectCommand.Parameters["@ФИО"].Value = ФИО;
            myData.SelectCommand.Parameters["@Паспорт"].Value = Паспорт;

            DataSet ds = new DataSet();
            myData.Fill(ds);

            StreamWriter writerfil;
            writerfil = new StreamWriter("C:\\inetpub\\wwwroot\\WebServiceSRV\\XMLFile1.xml");
            writerfil.WriteLine(ds.GetXml());
            writerfil.Close();
            
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST="
            + "(ADDRESS=(PROTOCOL=TCP)(HOST= 169.254.18.85 )(PORT=1521)))"
            + "(CONNECT_DATA=( SERVICE_NAME = DBA )));"
            + "User Id = system ; Password = manager ;";

            
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

            OracleDataAdapter OR = new OracleDataAdapter("select name,pasport,adress,period,status from gilo where name=&namekl", conn);
            OR.SelectCommand.Parameters.Add("&namekl",OracleType.VarChar,60);
            //OR.SelectCommand.Parameters.Add("&pasportkl", OracleType.Number);
            OR.SelectCommand.Parameters["&namekl"].Value = ФИО;
            //OR.SelectCommand.Parameters["&pasportkl"].Value = Паспорт;

            DataSet ds2 = new DataSet();
            OR.Fill(ds2);
            
            OR.Fill(ds);

            StreamWriter writerfil2;
            writerfil2 = new StreamWriter("C:\\inetpub\\wwwroot\\WebServiceSRV\\XMLFile2.xml");
            writerfil2.WriteLine(ds2.GetXml());
            writerfil2.Close();

            conn.Dispose();;

            return ds;
            
            
            
        }


    }
}