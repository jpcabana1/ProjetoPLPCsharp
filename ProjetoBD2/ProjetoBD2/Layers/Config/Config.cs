using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using ProjetoBD2.Models;

namespace ProjetoBD2.Config

{
    class Config
    {
        public static string ReadConfig()
        {
            string jsonString;
            ConfigModel model;
            try
            {
                jsonString = File.ReadAllText("Config.json");
                model = JsonSerializer.Deserialize<ConfigModel>(jsonString);
                return model.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
