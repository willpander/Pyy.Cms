﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        //public IActionResult Index()
        //{
        //    var contents = new List<Content>();
        //  for(int i = 0; i < 11; i++)
        //    {
        //        contents.Add(new Content { Id=i,title= $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
        //    }
        //    return View(new ContentViewModel { Contents=contents});
        //}

        private readonly List<Content> contents;

        public ContentController(IOptions<List<Content>> option)
        {
            var a = option.Value;
            contents = option.Value;
        }

        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = contents });
        }
    }
}