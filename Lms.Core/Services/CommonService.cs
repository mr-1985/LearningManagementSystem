using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Core.Services
{
    public class CommonService : ICommonService
    {
        private LmsContext _context;

        public CommonService(LmsContext context)
        {
            _context = context;
        }

        public List<City> GetAllCity()
        {
            return _context.Cities.ToList();
        }

        public List<SelectListItem> GetCityByProvinceIDSelectList(int ProvinceId)
        {
            return _context.Cities.Where(p => p.ProvinceId == ProvinceId)
                .Select(g => new SelectListItem()
                {
                    Text = g.CityName,
                    Value = g.CityId.ToString()
                }).ToList();
        }

        public List<Education> GetAllEducation()
        {
            return _context.Educations.ToList();
        }

        public List<SelectListItem> GetAllEducationSelectList()
        {
            return _context.Educations
                .Select(g => new SelectListItem()
                {
                    Text = g.Title,
                    Value = g.Id.ToString()
                }).ToList();
        }

        public List<LocationStatus> GetAllLocationStatus()
        {
            return _context.LocationStatuses.ToList();
        }

        public List<SelectListItem> GetAllLocationStatusSelectList()
        {
            return _context.LocationStatuses
                .Select(g => new SelectListItem()
                {
                    Text = g.Title,
                    Value = g.Id.ToString()
                }).ToList();
        }

        public List<Province> GetAllProvince()
        {
            return _context.Provinces.ToList();
        }

        public List<SelectListItem> GetAllProvinceSelectList()
        {
            return _context.Provinces
                .Select(g => new SelectListItem()
                {
                    Text = g.ProvinceName,
                    Value = g.ProvinceId.ToString()
                }).ToList();
        }

        public List<City> GetCityByProvinceID(int ProvinceId)
        {
            return _context.Cities.Where(c => c.ProvinceId == ProvinceId).ToList();

        }
    }
}
