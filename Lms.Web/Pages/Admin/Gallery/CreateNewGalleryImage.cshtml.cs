using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lms.Web.Pages.Admin.Gallery
{
    public class CreateNewGalleryImageModel : PageModel
    {
        private IImageService _imageService;

        public CreateNewGalleryImageModel(IImageService imageService)
        {
            _imageService = imageService;
        }

        [BindProperty]
        public DataLayer.Entities.Gallery Gallery { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost(IFormFile imgGalleryUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _imageService.AddImage(Gallery,imgGalleryUp);
            return RedirectToPage("Index");
        }
    }
}
