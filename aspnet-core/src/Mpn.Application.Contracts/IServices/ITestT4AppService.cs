/*
 * T4自动生成，只生成一次，存在不覆盖
 */
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Mpn.Dtos;
using Mpn.Models;

namespace Mpn.IServices
{
    public interface ITestT4AppService :
         ICrudAppService< //定义了CRUD方法
             TestT4Dto, //用来展示
             Guid, //实体的主键
             PagedAndSortedResultRequestDto, //获取时候用于分页和排序
             CreateUpdateTestT4Dto, //用于创建
             CreateUpdateTestT4Dto> //用于更新
    {

    }
}
