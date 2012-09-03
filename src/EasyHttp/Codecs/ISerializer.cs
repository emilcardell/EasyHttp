using System.IO;

namespace EasyHttp.Codecs
{
    public interface ISerializer
    {
        void Serialize(string contentType, object input , Stream outputStream);
        bool CanSerialize(string contentType);
    }
}