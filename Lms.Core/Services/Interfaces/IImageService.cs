using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;

namespace Lms.Core.Services.Interfaces
{
    public interface IImageService
    {
        int AddImage(Gallery gallery, IFormFile imgGallery);
       List<Gallery> GetAllImagesInGallery();
       Gallery GetImageById(int imageId);
       void UpdateImage(Gallery gallery, IFormFile imgGallery);
       void DeleteImage(int imageId);
    }
}
