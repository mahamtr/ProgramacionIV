using ASP.Controllers;
using Datos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISS_REST_API.Controllers
{
    public class OrdenDetalleController : BaseApiController
    {

        [HttpGet]
        [ActionName("getAllDetails")]
        public HttpResponseMessage getAllOrderDetails()
        {
            try
            {
                var query = OrdenDetalleRepository.getAll();
                return OkResponse(query);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        [HttpGet]
        [ActionName("getbyId")]
        public HttpResponseMessage getAllOrderDetailsbyId([FromUri] int i)
        {
            try
            {
                var query = OrdenDetalleRepository.getbyId(i);
                return OkResponse(query);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
    }
}
