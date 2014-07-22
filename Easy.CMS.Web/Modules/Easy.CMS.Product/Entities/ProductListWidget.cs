﻿using Easy.CMS.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Easy.Attribute;

namespace Easy.CMS.Product.Entities
{
    [DataConfigure(typeof(ProductListWidgetMetaData))]
    public class ProductListWidget : WidgetBase
    {
    }
    public class ProductListWidgetMetaData : DataViewMetaData<ProductListWidget>
    {
        protected override bool IsIgnoreBase()
        {
            return true;
        }
        protected override void DataConfigure()
        {
            DataTable("ProductListWidget");
            DataConfig(m => m.WidgetId).AsPrimaryKey();
        }

        protected override void ViewConfigure()
        {

        }
    }

}