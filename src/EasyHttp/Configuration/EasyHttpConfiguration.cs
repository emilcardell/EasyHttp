using System;
using System.Collections.Generic;
using EasyHttp.Codecs;
using EasyHttp.Http;

namespace EasyHttp.Configuration
{
    public class EasyHttpConfiguration
    {
        private static EasyHttpConfiguration currentConfiguration;
        public IList<ISerializer> Serializers { get; set; }
        public IList<IDeserializer> Deserializers { get; set; }
        public string RequestContentType { get; set; }

        public static EasyHttpConfiguration Current
        {
            get
            {
                if (currentConfiguration != null)
                    return currentConfiguration;

                currentConfiguration = Default;

                return currentConfiguration;
            }
        }


        public static void Override(Action<EasyHttpConfiguration> configurationBuilder)
        {
            var configuration = Default;
            if (currentConfiguration != null)
                configuration = currentConfiguration;

            configurationBuilder.Invoke(configuration);

            currentConfiguration = configuration;
        }

        public static EasyHttpConfiguration Default
        {
            get
            {
                return new EasyHttpConfiguration()
                {
                    Serializers = new List<ISerializer>(),
                    Deserializers = new List<IDeserializer>(),
                    RequestContentType = HttpContentTypes.ApplicationJson
                };
            }
        }
    }
}
