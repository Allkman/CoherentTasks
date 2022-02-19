using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task1.Logger
{
    public class Logger
    {
        private string _jsonFile;
        private static readonly Dictionary<string, string> log = new Dictionary<string, string>();
        public Logger(string jsonFile)
        {
            _jsonFile = $"{jsonFile}.json";
        }

        //https://stackoverflow.com/questions/6637679/reflection-get-attribute-name-and-value-on-property
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
