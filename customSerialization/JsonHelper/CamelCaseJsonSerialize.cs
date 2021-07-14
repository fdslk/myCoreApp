using models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JsonHelper
{
    public static class ConvertJson{
        public static string ConvertContentToJsonCamelCase(Student student){
            return JsonConvert.SerializeObject(
                student,
                Formatting.Indented,
                new JsonSerializerSettings{ContractResolver = new CamelCasePropertyNamesContractResolver()}
            );
        }
    }
}