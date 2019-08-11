using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ngNet.Web.Helpers
{
    public class JsonSettings
    {
        public static JsonSerializerSettings CamelCase
        {
            get
            {
                return new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    #if DEBUG
                    Formatting = Formatting.Indented,
                    #endif
                };
            }
        }
    }
}