using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string GalleyImageName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
