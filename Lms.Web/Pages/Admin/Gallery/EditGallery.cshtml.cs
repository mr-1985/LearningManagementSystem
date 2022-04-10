using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Gallery
{
    public class EditGalleryModel : PageModel
    {
        private IImageService _imageService;

        public EditGalleryModel(IImageService imageService)
        {
            _imageService = imageService;
        }

        [BindProperty]
        public DataLayer.Entities.Gallery Gallery { get; set; }
        public void OnGet(int id)
        {
            Gallery = _imageService.GetImageById(id);
        }

        public IActionResult OnPost(IFormFile imgGalleryUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _imageService.UpdateImage(Gallery, imgGalleryUp);
            return RedirectToPage("Index");
        }
    }
}
