using LoggerBL;
using System.Reflection;
using System.Text.Json;

namespace LoggerBL
{
    public class Logger
    {
        private string _jsonFile;
        private static readonly Dictionary<string, string> log = new Dictionary<string, string>();
        private string _propertyAttributeName;
        private string _propertyValue;        
        private string _fieldAttributeName;
        private string _fieldValue;
        public Logger(string jsonFile)
        {
            _jsonFile = $"{jsonFile}.json";
        }
        public void Track(object obj)
        {
            var classAttributes = obj.GetType().GetCustomAttributes(true);
            foreach (var classAttibute in classAttributes)
            {
                if (classAttibute is TrackingEntityAttribute)
                {
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        _propertyAttributeName = ((TrackingPropertyAttribute)property.GetCustomAttribute(typeof(TrackingPropertyAttribute)))?.Name;
                        _propertyValue = property.GetValue(obj).ToString();
                        if (_propertyAttributeName is null)
                        {
                            _propertyAttributeName = property.Name;
                        }
                        log.Add(_propertyAttributeName, _propertyValue);
                    }
                    foreach (var field in obj.GetType().GetFields())
                    {
                        _fieldAttributeName = ((TrackingPropertyAttribute)field.GetCustomAttribute(typeof(TrackingPropertyAttribute)))?.Name;
                        _fieldValue = field.GetValue(obj).ToString();
                        if (_fieldAttributeName is null)
                        {
                            _fieldAttributeName = field.Name;
                        }
                        log.Add(_fieldAttributeName, _fieldValue);
                    }
                }
            }
            File.WriteAllText($"C:{Path.DirectorySeparatorChar}Testing{Path.DirectorySeparatorChar}{_jsonFile}", JsonSerializer.Serialize(log));
        }
    }
}