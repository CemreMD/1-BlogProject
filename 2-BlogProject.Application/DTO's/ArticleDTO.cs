﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.DTO_s
{
    public class ArticleDTO
    {
        public string Id {  get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string AppUserId { get; set; }
        public string CategoryId { get; set; }
    }
}
