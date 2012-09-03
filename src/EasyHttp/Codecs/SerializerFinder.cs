using System.Collections.Generic;
using System.Linq;


namespace EasyHttp.Codecs
{
    public static class SerializerFinder
    {
        public static ISerializer GetDeserializerForContentType(this IList<ISerializer> serializers, string contentType)
        {
            var result = serializers.FirstOrDefault(x => x.CanSerialize(contentType));

            if (result == null)
                throw new SerializerNotFoundException("Serializer for content type " + contentType + " is not found.");

            return result;
        }
    }
}
