using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Gallery
{
    public class IndexModel : PageModel
    {
        private IImageService _imageService;

        public IndexModel(IImageService imageService)
        {
            _imageService = imageService;
        }

        public List<DataLayer.Entities.Gallery> Gallery { get; set; }
        public void OnGet()
        {
            Gallery = _imageService.GetAllImagesInGallery();
        }
    }
}