using BindRepordsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BindRepordsAPI.Controllers
{
    [RoutePrefix("Api/UserAPI")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("AllUser")]
        public IEnumerable<UserDetail> UserDetails()
        {
            IEnumerable<UserDetail> lstUser = new List<UserDetail>();
            string response = "";
            try
            {
                using (TutorialDemoEntities objEntity = new TutorialDemoEntities())
                {
                    lstUser = objEntity.UserDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }
            return lstUser;
        }
    }
}
