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
        public GPSData GetVehicleGPS(string Vin)
        {
            List<string> vinList = new List<string>()
            {
                "VEH01234567891011", "VEH01234567891012", "VEH01234567891013"
            };

            Random random = new Random();
            GPSData gpsData = new GPSData();
            if (vinList.Contains(Vin))
            {   
                gpsData.latitude = 42 + random.NextDouble();
                gpsData.longitude = -83 - random.NextDouble();

                return gpsData;
            }
            else
            {
                return gpsData;
            }
        }
    }

    public class GPSData
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
