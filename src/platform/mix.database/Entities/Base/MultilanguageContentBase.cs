﻿using Mix.Database.Entities.Cms.v2;
using System;

namespace Mix.Database.Entities.Base
{
    public abstract class MultilanguageContentBase<TPrimaryKey>: EntityBase<TPrimaryKey>
    {
        public string Specificulture { get; set; }
        public string DisplayName { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public int MixCultureId { get; set; }
        public virtual MixCulture MixCulture { get; set; }
    }
}