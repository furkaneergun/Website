﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class DownloadFormModel
    {
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a short description.")]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

    }
}
