using System.IO;
using Newtonsoft.Json;

namespace FileTranslator
{
    public class JsonFileTranslator<T>
    {
        public static T Translate(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}