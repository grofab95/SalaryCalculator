using System.IO;
using Newtonsoft.Json;

namespace JsonFileConverter
{
    public class JsonFileConverter
    {
        public static T ConvertFromFile<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static void ConvertToFile(string filePath, object contents)
        {
            var json = JsonConvert.SerializeObject(contents, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}