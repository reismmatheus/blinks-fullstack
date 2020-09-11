using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CampaignsController : ApiController
    {
        public HttpResponseMessage Get(string data)
        {
            var listCampaign = new CampaignRepository().GetByDate(data);
            if(listCampaign == null)
            {
                HttpError error = new HttpError("Unexpected Error");
                return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new { data = listCampaign, total = listCampaign.Count });
        }
    }
}
