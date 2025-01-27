﻿using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pdam.Common.Shared.Infrastructure;

namespace Pdam.Configuration.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{companyCode}")]
        public async Task<IActionResult> Get([FromRoute] string companyCode)
        {
            var response = await _mediator.Send(new Features.Company.Get.Request
            {
                CompanyCode = companyCode
            });
            return ActionResultMapper.ToActionResult(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Features.Company.Add.Request request)
        {
            var response = await _mediator.Send(request);
            return ActionResultMapper.ToActionResult(response);
        }
        
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Features.Company.Update.Request request)
        {
            var response = await _mediator.Send(request);
            return ActionResultMapper.ToActionResult(response);
        }
    }
}