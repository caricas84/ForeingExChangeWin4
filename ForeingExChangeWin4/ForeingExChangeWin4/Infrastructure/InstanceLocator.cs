﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeingExChangeWin4.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main
        {
            get;
            set;
        }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

    }
}
