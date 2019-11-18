using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace WebApplicationDemo
{
    /// <summary>
    /// Summary description for CarHandler
    /// </summary>
    public class CarHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string term = context.Request["term"] ?? "";

            List<String> listCarNames = new List<string>();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using(SqlConnection con = new SqlConnection(cs))
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

            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(listCarNames));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}