using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Convertors;
using Lms.Core.Generators;
using Lms.Core.Security;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;

namespace Lms.Core.Services
{
    public class ImageService:IImageService
    {
        private LmsContext _context;

        public ImageService(LmsContext context)
        {
            _context = context;
        }
        public int AddImage(Gallery gallery, IFormFile imgGallery)
        {
            gallery.CreateDate = DateTime.Now;
            gallery.GalleyImageName = "no-photo.jpg";
            //TODO Check Image
            if (imgGallery != null && imgGallery.IsImage())
            {
                gallery.GalleyImageName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgGallery.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages", gallery.GalleyImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgGallery.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages/Thumb", gallery.GalleyImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 250);
            }

            _context.Add(gallery);
            _context.SaveChanges();

            return gallery.GalleryId;
        }

        public List<Gallery> GetAllImagesInGallery()
        {
            return _context.Galleries.Where(i=>i.IsDelete==false).ToList();
        }

        public Gallery GetImageById(int imageId)
        {
            return _context.Galleries.Find(imageId);
        }

        public void UpdateImage(Gallery gallery, IFormFile imgGallery)
        {
            if (imgGallery != null && imgGallery.IsImage())
            {
                if (gallery.GalleyImageName != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages", gallery.GalleyImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages/thumb", gallery.GalleyImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                gallery.GalleyImageName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgGallery.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages", gallery.GalleyImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgGallery.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GalleryImages/thumb", gallery.GalleyImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 250);
            }

            _context.Galleries.Update(gallery);
            _context.SaveChanges();
        }

        public void DeleteImage(int imageId)
        {
            var image = GetImageById(imageId);
            image.IsDelete = true;
            _context.Galleries.Update(image);
            _context.SaveChanges();
        }
    }
}
