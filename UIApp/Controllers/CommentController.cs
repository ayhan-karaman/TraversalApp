using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.Controllers
{
    public class CommentController:Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Entities.Concrete.Comment comment)
        {
            
            var result =  _commentService.Add(comment);
            if(result.Success)
            {
                return RedirectToAction("Index", "Destination");
            }
                return RedirectToAction("AddComment", "Comment");
            
        }
    }
}