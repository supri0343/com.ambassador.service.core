﻿using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/standard-tests")]
    public class StandardTestsController : BasicController<StandardTestsService, StandardTests, StandardTestsViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public StandardTestsController(StandardTestsService service) : base(service, ApiVersion)
        {
        }
    }
}
