
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ECommerce.Common.JsonHelpers
{
    public static class SessionHelper
    {
        public static void SetJsonProduct(this ISession _session, string _key, object _value)
        {
            var jsonSerialize = JsonConvert.SerializeObject(_value);
            _session.SetString(_key, jsonSerialize);
        }

        public static T GetProductFromJson<T>(this ISession _session, string _key)
        {
            var result = _session.GetString(_key);

            if (result == null)
            {
                return default(T);
            }
            else
            {
                var jsonDeserialize = JsonConvert.DeserializeObject<T>(result);
                return jsonDeserialize;
            }
        }
    }
}
