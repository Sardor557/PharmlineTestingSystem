using Newtonsoft.Json;

namespace PharmlineTestingSystem.Utils
{
    public static class CSerializerJson
    {
        public static T ToObj<T>(string value) where T : class
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string ToJson(this object inParam, Formatting format = Formatting.None, NullValueHandling nullValueHandling = NullValueHandling.Ignore)
        {
            if (inParam == null)
                return "{}";
            return JsonConvert.SerializeObject(inParam, format, new JsonSerializerSettings { NullValueHandling = nullValueHandling });
        }
        public static T FromJson<T>(this string inParam)
        {
            if (string.IsNullOrWhiteSpace(inParam))
                return default;
            return JsonConvert.DeserializeObject<T>(inParam);
        }
    }
}
