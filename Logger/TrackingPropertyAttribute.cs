namespace LoggerBL
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.attributetargets?view=net-6.0
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class TrackingPropertyAttribute : Attribute 
    {
        public string Name { get; }

        public TrackingPropertyAttribute(string name)
        {
            Name = name;
        }

        public TrackingPropertyAttribute()
        {

        }
    }
}