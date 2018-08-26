using System.IO;
using Newtonsoft.Json;

namespace KalkulatorWynagrodzen
{
    public class ConfigurationFileInterpreter<T>// To są typy generyczne, umożliwiają pisanie "ogólnego" kodu, który nie zależy od typu. Będzie działać dla różnych klas.
    {
        private readonly string _configurationFilePath;
        public ConfigurationFileInterpreter(string configurationFilePath)
        {
            _configurationFilePath = configurationFilePath;
        }

        public T InterpretConfiguration()
        {
            var json = File.ReadAllText(_configurationFilePath); // Usunąłbym tą linijkę nawet ;) Zostawiam, łatwiej będzie Ci zrozumieć.
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
// Ta klasa będzie mogła zwrócić obiekt dowolnego typu z odczytanego pliku, którego ściażka zostanie przekazana jako paramter konstruktora.