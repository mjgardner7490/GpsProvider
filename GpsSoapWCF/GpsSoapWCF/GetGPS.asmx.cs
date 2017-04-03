using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GpsSoapWCF
{
    /// <summary>
    /// Summary description for GetGPS
    /// </summary>
    [WebService(Namespace = "http://GpsProvider.azurewebsites.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetGPS : System.Web.Services.WebService
    {
        [WebMethod]
        public List<VinLocation> GetVehicleGPS(List<string> Vins)
        {
            Random random = new Random();
            GPSData gpsData = new GPSData();

            var vinLocationList = new List<VinLocation>();
            foreach (var vin in Vins)
            {
                var vinLocation = new VinLocation()
                {
                    Vin = vin,
                    GPS = new GPSData()
                    {
                        Latitude = 42 + random.NextDouble(),
                        Longitude = -83 - random.NextDouble()
                    }
                };

                vinLocationList.Add(vinLocation);
            }

            return vinLocationList;
        }
    }

    public class GPSData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class VinLocation
    {
        public string Vin { get; set; }
        public GPSData GPS { get; set; }
    }
}
