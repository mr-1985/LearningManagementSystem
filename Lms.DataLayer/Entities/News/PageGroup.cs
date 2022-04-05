using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities.News
{
    public class PageGroup
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        [Display(Name = "حذف شده ؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }

        //Navigation Property

        [ForeignKey("ParentId")]
        public List<PageGroup> PageGroups { get; set; }

        [InverseProperty("MainGroup")]
        public List<Page> MainPages { get; set; }

        [InverseProperty("SubGroup")]
        public List<Page> SubPages { get; set; }
    }
}
