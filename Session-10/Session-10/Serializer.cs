using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session_10
{
    internal class Serializer
    {
        public void SerializeTofile(object obj, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(obj);

            File.WriteAllText(fileName, jsonString);
        }
    }
}
