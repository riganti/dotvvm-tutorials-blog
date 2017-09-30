using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotvvmBlog.ViewModels
{
    public abstract class LayoutViewModel : DotvvmViewModelBase
    {

        public abstract string MenuSection { get; }

    }
}

