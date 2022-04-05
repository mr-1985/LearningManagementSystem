using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Core.Services.Interfaces
{
    public interface ICommonService
    {
        List<City> GetAllCity();
        List<Province> GetAllProvince();
        List<SelectListItem> GetAllProvinceSelectList();
        List<City> GetCityByProvinceID(int ProvinceId);
        List<SelectListItem> GetCityByProvinceIDSelectList(int ProvinceId);
        List<Education> GetAllEducation();
        List<SelectListItem> GetAllEducationSelectList();
        List<LocationStatus> GetAllLocationStatus();
        List<SelectListItem> GetAllLocationStatusSelectList();
    }
}
