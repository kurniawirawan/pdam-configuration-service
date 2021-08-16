﻿using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pdam.Common.Shared.Infrastructure;

namespace Pdam.Configuration.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BranchController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{companyCode}/{branchCode}")]
        public async Task<IActionResult> Get([FromRoute] string companyCode, [FromRoute] string branchCode)
        {
            var response = await _mediator.Send(new Features.Branch.Get.Request
            {
                CompanyCode = companyCode,
                BranchCode = branchCode
            });
            return ActionResultMapper.ToActionResult(response);
        }
    }
}