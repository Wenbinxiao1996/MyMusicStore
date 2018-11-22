﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Titile { get; set; }//标题
        public DateTime ReleaseDate { get; set; } //上映时间
        public string Genre { get; set; } //电影分类
        public decimal Price { get; set; }//价格

        public Movie() {
            ID = Guid.NewGuid();
            ReleaseDate = DateTime.Now;
        }
    }
}