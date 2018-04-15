﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.Models
{
    public class Article
    {
        public int ID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string AuthorID { get; set; }
        [Required]
        public DateTime DT { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Text { get; set; }
    }
}