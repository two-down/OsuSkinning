using System.IO;
using System.Xml.Serialization;

namespace OsuSkinning.BL.Utility
{
    public static class SerializationHelper<T>
    {
        public static void Serialize(T obj, string fileName)
        {
            var formatter = new XmlSerializer(typeof(T));

            using (var fs = new FileStream($"{fileName}.xml", FileMode.CreateNew))
                formatter.Serialize(fs, obj);
        }

        public static T Deserialize(string fileName)
        {
            var formatter = new XmlSerializer(typeof(T));

            //if (File.Exists($"{fileName}.xml") == false)

            using (var fs = new FileStream($"{fileName}.xml", FileMode.Open))
                return (T)formatter.Deserialize(fs);
        }
    }
}