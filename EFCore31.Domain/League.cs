﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore31.Domain
{
    public class League
    {
        [Description("主键")]
        [Display(Name = "主键")]
        public int Id { get; set; }

        //[DisplayName("名称")]
        [Display(Description = "描述", Name = "名称", Prompt = "提示")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [DisplayName("国家")]
        [Required, MaxLength(100)]
        public string Country { get; set; }
    }
}
