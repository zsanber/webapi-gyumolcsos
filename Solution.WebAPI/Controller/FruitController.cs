using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Solution.Core.Interfaces.IServices;
using Solution.Core.Models;
using Solution.Core.Models.Entities;
using Solution.Core.Models.Requests;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;

namespace Solution.WebAPI.Controller
{
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitService _FruitService;

        public FruitController(IFruitService FruitService)
        {
            _FruitService = FruitService;
        }

        [HttpGet]
        [Route("/api/Fruit/get-all")]
        [SwaggerOperation(OperationId = "getAll")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Fruit>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<List<Fruit>> GetAll()
        {
            ServiceResponse<List<Fruit>> request = await _FruitService.GetAllAsync();

            if(request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }

        [HttpGet]
        [Route("/api/Fruit/get/{id}")]
        [SwaggerOperation(OperationId = "get")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Fruit))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<Fruit> Get([FromRoute][Required] int id)
        {
            ServiceResponse<Fruit> request = await _FruitService.GetAsync(id);

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }

        [HttpGet]
        [Route("/api/Fruit/page/{page}")]
        [SwaggerOperation(OperationId = "page")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Fruit>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<List<Fruit>> Page([FromRoute][Required] int page = 0)
        {
            ServiceResponse<List<Fruit>> request = await _FruitService.PageAsync(page);

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }

        [HttpDelete]
        [Route("/api/Fruit/delete/{id}")]
        [SwaggerOperation(OperationId = "delete")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<bool> Delete([FromRoute][Required] int id)
        {
            ServiceResponse request = await _FruitService.DeleteAsync(id);

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return true;
        }

        [HttpPost]
        [Route("/api/Fruit/create")]
        [SwaggerOperation(OperationId = "create")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Fruit))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<Fruit> Create([FromBody][Required] FruitRequest requestParam)
        {
            ServiceResponse<Fruit> request = await _FruitService.CreateAsync(requestParam);

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }

        [HttpPut]
        [Route("/api/Fruit/update")]
        [SwaggerOperation(OperationId = "update")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Fruit))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<Fruit> Update([FromBody][Required] Fruit requestParam)
        {
            ServiceResponse<Fruit> request = await _FruitService.UpdateAsync(requestParam);

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }
    }
}
