using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UIApp.ViewComponents.Comment
{
    public class CommentListViewComponent:ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentListViewComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int destinationId)
        {
            var result = _commentService.GetAllByDestinationID(destinationId);
            
            return View(result);
        }
    }
}