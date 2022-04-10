using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Gallery
{
    public class DeleteGalleryModel : PageModel
    {
        private IImageService _imageService;

        public DeleteGalleryModel(IImageService imageService)
        {
            _imageService = imageService;
        }

        [BindProperty]
        public DataLayer.Entities.Gallery Gallery { get; set; }
        public void OnGet(int id)
        {
            Gallery = _imageService.GetImageById(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _imageService.DeleteImage(Gallery.GalleryId);
            return RedirectToPage("Index");
        }
    }
}
