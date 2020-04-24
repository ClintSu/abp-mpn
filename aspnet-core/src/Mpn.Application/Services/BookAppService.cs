﻿using System;
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
    public class BookAppService :
         CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto,
                             CreateUpdateBookDto, CreateUpdateBookDto>,
         IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
