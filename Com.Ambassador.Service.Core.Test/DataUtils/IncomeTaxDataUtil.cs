﻿using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class IncomeTaxDataUtil : BasicDataUtil<CoreDbContext, IncomeTaxService, IncomeTax>, IEmptyData<IncomeTaxViewModel>
    {

        public IncomeTaxDataUtil(CoreDbContext dbContext, IncomeTaxService service) : base(dbContext, service)
        {
        }

        public IncomeTaxViewModel GetEmptyData()
        {
            IncomeTaxViewModel Data = new IncomeTaxViewModel();
            
            return Data;
        }

        public override IncomeTax GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            IncomeTax TestData = new IncomeTax
            {
                Name = guid,
                Rate = 1,
                Description="test",
                COACodeCredit = "1110"
            };

            return TestData;
        }

        public override async Task<IncomeTax> GetTestDataAsync()
        {
            IncomeTax Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}