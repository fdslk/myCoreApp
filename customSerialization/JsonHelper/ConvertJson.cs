using models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JsonHelper
{
    public static class ConvertJson{
        public static string ConvertContentToJsonCamelCase(object obj){
            return JsonConvert.SerializeObject(
                obj,
                Formatting.Indented,
                new JsonSerializerSettings{ContractResolver = new CamelCasePropertyNamesContractResolver()}
            );
        }

        public static string ConvertContentUsingCustomContractResolver(object obj, IContractResolver customContractResolver){
            return JsonConvert.SerializeObject(
                obj,
                Formatting.Indented,
                new JsonSerializerSettings{ContractResolver = customContractResolver}
            );
        }
    }
}