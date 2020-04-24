/*
 * T4自动生成，只生成一次，存在不覆盖
 */
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Mpn.IServices;
using Mpn.Dtos;
using Mpn.Models;

namespace Mpn.Services
{
    public class TestT4AppService : CrudAppService<TestT4, TestT4Dto, Guid, PagedAndSortedResultRequestDto,CreateUpdateTestT4Dto, CreateUpdateTestT4Dto>,ITestT4AppService
    {
        public TestT4AppService(IRepository<TestT4, Guid> repository) : base(repository)
        {

        }
    }
}

