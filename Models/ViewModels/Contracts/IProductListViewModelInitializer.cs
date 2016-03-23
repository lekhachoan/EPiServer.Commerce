﻿using Mediachase.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.Commerce.Models.ViewModels.Contracts
{
    public interface IProductListViewModelInitializer
    {
        ProductListViewModel Populate(IMarket currentMarket); 
    }
}
