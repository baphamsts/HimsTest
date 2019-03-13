using System;
using System.Configuration;
using System.Globalization;

public static class AppSettings
{
    public static string ApiEndPoint
    {
        get
        {
            return Setting<string>("ApiEndPoint");
        }
    }

    private static T Setting<T>(string name)
    {
        string value = ConfigurationManager.AppSettings[name];

        if (value == null)
        {
            throw new Exception(String.Format("Could not find setting '{0}',", name));
        }

        return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
    }
}