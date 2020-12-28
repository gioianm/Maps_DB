using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Maps.Models
{
    public class MapManager
    {
        const string API_KEY = "AIzaSyAv3o_CO_lsfWe19Vm8YRIVC84de_54Rak";
        const string URL_API = "https://www.google.ru/maps/api/geocode/xml?key=" + API_KEY + "&address=";
        const string XML_PATH = "GeocodeResponse/result/geometry/location/";
        public static void SetCoords (Worker worker)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(URL_API + HttpUtility.UrlEncode(worker.address));
            worker.lat = xml.SelectSingleNode(XML_PATH + "lat").InnerText;
            worker.lng = xml.SelectSingleNode(XML_PATH + "lng").InnerText;
        }
    }
}