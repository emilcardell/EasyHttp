using System;
using System.Collections.Generic;
using System.IO;
using EasyHttp.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EasyHttp.Codecs
{
    public class DefaultDeserializer : IDeserializer
    {
        private readonly JsonSerializer jsonSerializer = new JsonSerializer();
        
        public DefaultDeserializer() { }

        public DefaultDeserializer(IEnumerable<JsonConverter> converters)
        {
            foreach (var converter in converters)
                jsonSerializer.Converters.Add(converter);
        }

        public T DeserializeToStatic<T>(string input, string contentType)
        {
            return jsonSerializer.Deserialize<T>(new JsonTextReader(new StringReader(input)));
        }

        public dynamic DeserializeToDynamic(string input, string contentType)
        {
            return JObject.Parse(input);
        }

        public bool CanDeserialize(string contentType)
        {
            return contentType.Equals(HttpContentTypes.ApplicationJson, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}