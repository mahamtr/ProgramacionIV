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
    public class LocalidadController : BaseApiController
    {

        [HttpGet]
        [ActionName("getbyid")]
        public HttpResponseMessage GetById([FromUri]int id)
        {
            try
            {
                var exito = LocalidadRepository.GetById(id);
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
                var exito = LocalidadRepository.Remove(id);
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
        public HttpResponseMessage UpdateById([FromBody]Localidad i)
        {
            try
            {
                var exito = LocalidadRepository.UpdateById(i);
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

        [HttpGet]
        [ActionName("getAll")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                if (!isAuthentited())
                {
                    return Unauthorized("Sin Autorizacion");
                }
                var localidad = LocalidadRepository.GetAll();

                return OkResponse(localidad);
            }
            catch (Exception e)
            {
                return ErrorResponse_Ex(e);
                throw e;
            }
        }



        [HttpPost]
        [ActionName("addLocalidad")]
        public HttpResponseMessage AddLocalidad([FromBody]Localidad i)
        {
            try
            {
                var exito = LocalidadRepository.Add(i);
                if (exito)
                {
                    return OkResponse("EXITO");
                }
                return ErrorResponse("ERROR");
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}