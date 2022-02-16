
namespace Task1.Logger
{
    internal class TrackingPropertyAttribute : Attribute
    {
        //public TrackingPropertyAttribute(string propertyName)
        //{
        //    PropertyName = propertyName;
        //}

        public string PropertyName { get; set; }

    }
}