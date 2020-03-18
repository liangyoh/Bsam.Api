using Bsam.Core.IRepository;
using Bsam.Core.IRepository.UnitOfWork;
using Bsam.Core.Model.Models;
using Bsam.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Repository
{
    public class BlogArticleRepository : BaseRepository<BlogArticle>, IBlogArticleRepository
    {
        public BlogArticleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
