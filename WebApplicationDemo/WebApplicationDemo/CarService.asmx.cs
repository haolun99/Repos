using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace WebApplicationDemo
{
    /// <summary>
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetCarNames(string term)
        {
            

            List<String> listCarNames = new List<string>();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spgetBrands", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@term",
                    Value = term
                });
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listCarNames.Add(rdr["BrandName"].ToString());
                }
            }
            // string[]  x = new string[] { "tesla", "ford" };
            // JavaScriptSerializer js = new JavaScriptSerializer();
            //  Context.Response.Write(js.Serialize(x));

            return listCarNames;

        }
    }
}
