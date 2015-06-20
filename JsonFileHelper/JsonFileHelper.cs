using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JsonFileHelper
{
    public static class JsonFileHelper
    {

        public static T Read<T>(string filePath)
        {
            T result = default(T);
            if (File.Exists(filePath))
            {
                result = JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
            }
            return result;
        }

        public static void Write<T>(string filePath, T data)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(data));
        }

    }
}
