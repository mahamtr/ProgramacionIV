using ASP.Controllers;
using Datos.Repository;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISS_REST_API.Controllers
{
    public class AutoController : BaseApiController
    {
        [HttpGet]
        [ActionName("getbyid")]
        public HttpResponseMessage GetById([FromUri]int id)
        {
            try
            {
                var exito = AutoRepository.GetById(id);
                return OkResponse(exito);
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
        }

        [HttpGet]
        [ActionName("removeById")]
        public HttpResponseMessage RemoveById([FromUri]int id)
        {
            try
            {
                var exito = AutoRepository.Remove(id);
                if (exito)
                {
                    return OkResponse("EXITO");

                }
                return OkResponse("ERROR");

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        [ActionName("updateById")]
        public HttpResponseMessage UpdateById([FromBody]Auto i)
        {
            try
            {
                var exito = AutoRepository.UpdateById(i);
                if (exito)
                {
                    return OkResponse("EXITO");

                }
                return OkResponse("ERROR");

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
        }

        [HttpGet]
        [ActionName("getAll")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var Auto = AutoRepository.GetAllCars();

                return OkResponse(Auto);
            }
            catch (Exception e)
            {
                return ErrorResponse_Ex(e);
                throw e.InnerException;
            }
        }



        [HttpPost]
        [ActionName("addAuto")]
        public HttpResponseMessage AddAuto([FromBody]Auto i)
        {
            try
            {
                var exito = AutoRepository.Add(i);
                if (exito)
                {
                    return OkResponse("EXITO");
                }
                return ErrorResponse("ERROR");
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
    }
}
