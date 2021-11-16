﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairFlow.Entities
{
    public class Category
    {
        public int Id {get; set ;}

        [Required]
        [StringLength(200,MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
    }
}
