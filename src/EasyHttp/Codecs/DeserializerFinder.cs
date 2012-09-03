using System.Collections.Generic;
using System.Linq;

namespace EasyHttp.Codecs
{
    public static class DeserializerFinder
    {
        public static IDeserializer GetDeserializerForContentType(this IList<IDeserializer> deserializers, string contentType)
        {
            var result = deserializers.FirstOrDefault(x => x.CanDeserialize(contentType));
            if(result == null)
                throw new DeserializerNotFoundException("Deserializer for content type " + contentType + " is not found.");
            
            return result;
        }
    }
}
