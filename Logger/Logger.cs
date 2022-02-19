using LoggerBL;
using System.Text.Json;

namespace LoggerBL
{
    public class Logger
    {
        private string _jsonFile;
        private static readonly Dictionary<string, string> log = new Dictionary<string, string>();
        public Logger(string jsonFile)
        {
            _jsonFile = $"{jsonFile}.json";
        }
        public void Track(object obj)
        {
            var classAttributes = obj.GetType().GetCustomAttributes(true);
            foreach (var classAttibute in classAttributes)
            {
                var trackingEntityAttribute = classAttibute as TrackingEntityAttribute;
                if (trackingEntityAttribute != null)  /*classAttibute.GetType().Name == "TrackingEntityAttribute"*/
                {
                    var properties = obj.GetType().GetProperties();
                    foreach (var property in properties)
                    {
                        var propertyAttributes = property.GetCustomAttributes(true);
                        foreach (var propertyAttribute in propertyAttributes)
                        {
                            var trackingPropertyAttribute = propertyAttribute as TrackingPropertyAttribute;
                            if (trackingPropertyAttribute != null)
                            {
                                string propertyName = property.Name;
                                string value = property.GetValue(obj).ToString();
                                log.Add(propertyName, value);
                                File.WriteAllText($"C:{Path.DirectorySeparatorChar}Testing{Path.DirectorySeparatorChar}{_jsonFile}", JsonSerializer.Serialize(log));
                            }
                        }
                    }
                }
            }
        }
    }
}