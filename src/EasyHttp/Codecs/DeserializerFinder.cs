using System.Collections.Generic;
using System.Linq;

namespace EasyHttp.Codecs
{
    public static class DeserializerFinder
    {
        public static IDeserializer GetDeserializerForContentType(this IList<IDeserializer> deserializers, string contentType)
        {
            return deserializers.FirstOrDefault(x => x.CanDeserialize(contentType));
        }
    }
}
