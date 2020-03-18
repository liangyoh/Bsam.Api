using Bsam.Core.IRepository;
using Bsam.Core.IServices;
using Bsam.Core.Model.Models;
using Bsam.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Services
{
    public class BlogArticleServices : BaseServices<BlogArticle>, IBlogArticleServices
    {

        IBlogArticleRepository _dal;
        public BlogArticleServices(IBlogArticleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
