using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWebAPI.Services;
using System.Net.Http;

namespace CoreWebAPI.Controllers
{
    public class CitiesController : Controller
    {
        private CityService _cityService;
        private readonly string _baseAddress = "https://www.google.com/";

        public CitiesController()
        {
            _cityService = new CityService();
        }

        [HttpGet]
        [Route("api/Cities/GetAllCities")]
        public JsonResult GetCities()
        {
            return new JsonResult(_cityService.GetAllCities());
        }

        [HttpGet]
        [Route("api/Cities/GetMostPopulousCity")]
        public JsonResult GetMostPopulousCity()
        {
            return new JsonResult(_cityService.GetMostPopulousCity());
        }

        [HttpGet]
        [Route("api/Cities/GetLeastPopulousCity")]
        public JsonResult GetLeastPopulousCity()
        {
            return new JsonResult(_cityService.GetLeastPopulousCity());
        }

        //e.g. api/Cities/GetCitiesByState/IL
        [HttpGet]
        [Route("api/Cities/GetCitiesByState/{state}")]
        public JsonResult GetCitiesByState(string state)
        {
            return new JsonResult(_cityService.GetCitiesByStateAbbrev(state));
        }

        [HttpGet]
        [Route("api/Cities/GetZipCodeOfCity/{city}")]
        public JsonResult GetZipCodeOfCity(string city)
        {
            return new JsonResult(GetZipCodeFromGoogle(city));
        }

        #region Private Methods
        private async Task<string> GetZipCodeFromGoogle(string city){
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_baseAddress);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
        #endregion
    }
}
