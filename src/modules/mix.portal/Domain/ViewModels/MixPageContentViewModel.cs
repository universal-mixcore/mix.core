﻿using Mix.Database.Entities.Cms.v2;
using Mix.Heart.Repository;
using Mix.Heart.UnitOfWork;
using Mix.Lib.Attributes;
using Mix.Portal.Domain.Base;
using System.Threading.Tasks;

namespace Mix.Portal.Domain.ViewModels
{
    [GenerateRestApiController]
    public class MixPageContentViewModel 
        : SiteContentSEOViewModelBase<MixCmsContext, MixPageContent, int>
    {
        #region Contructors

        public MixPageContentViewModel()
        {
        }

        public MixPageContentViewModel(Repository<MixCmsContext, MixPageContent, int> repository) : base(repository)
        {
        }

        public MixPageContentViewModel(MixPageContent entity, UnitOfWorkInfo uowInfo = null) : base(entity, uowInfo)
        {
        }

        public MixPageContentViewModel(UnitOfWorkInfo unitOfWorkInfo) : base(unitOfWorkInfo)
        {
        }
        #endregion

        #region Properties

        public string ClassName { get; set; }

        #endregion

        public override async Task<int> CreateParentAsync()
        {
            MixPageViewModel parent = new(UowInfo)
            {
                DisplayName = DisplayName,
                Description = Description
            };
            return await parent.SaveAsync();
        }
    }
}