﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using Prism.Ioc;
using Prism.Modularity;

namespace DataProvider
{
    public class DataProviderModule:IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IPeopleProvider, PeopleProvider>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}
