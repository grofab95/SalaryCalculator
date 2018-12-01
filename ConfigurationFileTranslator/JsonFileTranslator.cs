using System.IO;
using Newtonsoft.Json;

namespace FileTranslator
{
    public class JsonFileTranslator
    {
        public static T ReadFrom<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static void WriteTo(string filePath, object contents)
        {
            var json = JsonConvert.SerializeObject(contents, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}