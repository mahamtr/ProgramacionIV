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
    public class OrdenController : BaseApiController
    {
        [HttpPost]
        [ActionName("addOrden")]
        public HttpResponseMessage AddOrden([FromBody] Orden U)
        {
            try
            {
                var exito = OrdenRepository.Add(U);
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


        [HttpGet]
        [ActionName("getOrdenes")]
        public HttpResponseMessage GetAllOrdenes()
        {
            try
            {
                var usuarios = OrdenRepository.GetAllOrden();
                return OkResponse(usuarios);
            }
            catch (Exception e)
            {
                return ErrorResponse_Ex(e.InnerException);
                throw e.InnerException;
            }
        }


        [HttpGet]
        [ActionName("getbyid")]
        public HttpResponseMessage GetById([FromUri]int id)
        {
            try
            {
                var exito = OrdenRepository.GetById(id);
                return OkResponse(exito);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpGet]
        [ActionName("removeById")]
        public HttpResponseMessage RemoveById([FromUri]int id)
        {
            try
            {
                var exito = OrdenRepository.Remove(id);
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
        public HttpResponseMessage UpdateById([FromBody]Orden i)
        {
            try
            {
                var exito = OrdenRepository.UpdateById(i);
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
    }
}