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
    public class UsuariosController : BaseApiController
    {

        [HttpPost]
        [ActionName("addUser")]
        public HttpResponseMessage AddUser([FromBody] Usuarios U)
        {
            try
            {
                var exito = UsuarioRepository.Add(U);
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
        [ActionName("getUsers")]
        public HttpResponseMessage GetAllUsers()
        {
            try
            {
                var usuarios = UsuarioRepository.GetAllUsers();
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
                var exito = UsuarioRepository.GetById(id);
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
                var exito = UsuarioRepository.Remove(id);
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
        public HttpResponseMessage UpdateById([FromBody]Usuarios i)
        {
            try
            {
                var exito = UsuarioRepository.UpdateById(i);
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

