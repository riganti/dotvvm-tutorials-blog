using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotvvmBlog.ViewModels
{
    public class DefaultViewModel : LayoutViewModel
    {
        public override string MenuSection => "Home";
    }
}
