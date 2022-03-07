using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.Core.Interfaces.IServices;
using Solution.Core.Models;
using Solution.Core.Models.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Solution.WebAPI.Controller
{
    [ApiController]
    public class NutritionInfoController : ControllerBase
    {
        private readonly INutritionInfoService _NutritionInfoService;

        public NutritionInfoController(INutritionInfoService NutritionInfoService)
        {
            _NutritionInfoService = NutritionInfoService;
        }

        [HttpGet]
        [Route("/api/nutritions/get-all")]
        [SwaggerOperation(OperationId = "getAll")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<NutritionInfo>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<List<NutritionInfo>> GetAll()
        {
            ServiceResponse<List<NutritionInfo>> request = await _NutritionInfoService.GetAllAsync();

            if (request.HasError)
            {
                throw new Exception(request.ErrorMessage);
            }

            return request.Object;
        }
    }
}
