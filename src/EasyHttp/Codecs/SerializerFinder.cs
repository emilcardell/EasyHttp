using System.Collections.Generic;
using System.Linq;


namespace EasyHttp.Codecs
{
    public static class SerializerFinder
    {
        public static ISerializer GetDeserializerForContentType(this IList<ISerializer> serializers, string contentType)
        {
            return serializers.FirstOrDefault(x => x.CanSerialize(contentType));
        }
    }
}
