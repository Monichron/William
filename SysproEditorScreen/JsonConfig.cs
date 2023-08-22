using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SysproEditorScreen
{
    public static class JsonConfig
    {
        public static Dictionary<string, string> Appsettings { get; set; }
         static JsonConfig()
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources/JsonConfig.txt");
            string jsonString = File.ReadAllText(filePath);
            Dictionary<string, string> dictionary = ConvertJsonToDictionary(jsonString);
            Appsettings = dictionary;
        }
        static Dictionary<string, string> ConvertJsonToDictionary(string json)
        {
            JObject jObject = JObject.Parse(json);

            Dictionary<string, string> dictionary = jObject.ToObject<Dictionary<string, string>>();

            return dictionary;
        }

        static Dictionary<string, string> GetAppsettings()
        {
            return Appsettings;
        }
    }
}
