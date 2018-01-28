using System.Collections.Generic;
using System.Linq;
using CoreWebAPI.Models;

namespace CoreWebAPI.Services
{
    public class CityService : ICityService
    {
        public IList<CityDto> GetAllCities()
        {
            return CitiesDataStore.Current.Cities.ToList();
        }

        public string GetMostPopulousCity()
        {
            return CitiesDataStore.Current.Cities.OrderByDescending(x => x.Population).Select(x => x.CityName).FirstOrDefault();
        }

        public string GetLeastPopulousCity()
        {
            return CitiesDataStore.Current.Cities.OrderBy(x => x.Population).Select(x => x.CityName).FirstOrDefault();
        }

        public IList<CityDto> GetCitiesByStateAbbrev(string stateAbbrev)
        {
            return CitiesDataStore.Current.Cities.Where(x => x.State == stateAbbrev).ToList();
        }
    }
}
