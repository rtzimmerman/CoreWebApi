using System;
using System.Collections.Generic;
using CoreWebAPI.Models;

namespace CoreWebAPI.Services
{
    public interface ICityService
    {
        IList<CityDto> GetAllCities();
        string GetMostPopulousCity();
        string GetLeastPopulousCity();
        IList<CityDto> GetCitiesByStateAbbrev(string stateAbbrev);
    }
}
