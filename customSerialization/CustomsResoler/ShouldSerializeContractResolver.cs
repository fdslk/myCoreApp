using System.Reflection;
using Model;
using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CustomResovler
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        public static readonly ShouldSerializeContractResolver Instance = new ShouldSerializeContractResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType == typeof(Employee) && property.PropertyName == "Manager")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        Employee employee = (Employee)instance;
                        return employee.Manager != employee;
                    };
            }

            return property;
        }
    }
}