using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AllergyHistory.Helpers
{
    public static class XmlHelper
    {
        public static T DeserializeXMLStringToObject<T>(string wellFormatXml)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(wellFormatXml)) return default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(wellFormatXml))
            {
                try
                {
                    returnObject = (T)serializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            return returnObject;
        }
    }
}
