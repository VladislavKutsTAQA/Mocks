using static Newtonsoft.Json.JsonConvert;

namespace MockServices.Idp
{
    public static class CloneHelper
    {
        public static T Clone<T>(this T obj)
        {
            var clonedJson = SerializeObject(obj);
            var clonedClass = DeserializeObject<T>(clonedJson);

            return clonedClass;
        }
    }
}