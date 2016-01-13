using API.Models.Setor;
using Business.Services;
using Infraestructure.Data;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/v1/setor")]
    public class SetorController : ApiController
    {
        private SetorService _service;

        public SetorController()
        {
            _service = new SetorService(new SetorRepository(new AppDataContext()));
        }

        [HttpPost]
        [Route("")]
        public Task<HttpResponseMessage> Post(CadastraSetorModel model)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                _service.Cadastrar(model.NomeSetor);
                response = Request.CreateResponse(HttpStatusCode.OK, new { nome = model.NomeSetor });
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);

            return tsc.Task;
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
        }
    }
}
