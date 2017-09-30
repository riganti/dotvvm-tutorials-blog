using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;
using DotvvmBlog.DTO;

namespace DotvvmBlog.ViewModels
{
    public class RegisterViewModel : LayoutViewModel
    {

        public override string MenuSection => "Register";


        public RegisterDTO Data { get; set; } = new RegisterDTO();

        public CategoryDTO[] Categories => new[]
        {
            new CategoryDTO() { Id = 1, Name = "Business" },
            new CategoryDTO() { Id = 2, Name = "Culture" },
            new CategoryDTO() { Id = 3, Name = "Design" },
            new CategoryDTO() { Id = 4, Name = "Fashion" },
            new CategoryDTO() { Id = 5, Name = "Lifestyle" },
            new CategoryDTO() { Id = 6, Name = "Technology" },
            new CategoryDTO() { Id = 7, Name = "Travel" },
        };


        public void Submit()
        {
            // will be implemented in some of the next parts
        }

    }
}

