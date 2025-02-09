using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program04
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Configuration - Json");

            UseJsonStreamConfig();
        }

        private void UseJsonStreamConfig()
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonStream(MakeJsonStreamConfig());

            IConfiguration config = configBuilder.Build();

            string val = "";

            val = config["AKey"];
            Console.WriteLine($"value of AKey = {val}");

            val = config["DArr:0:D1Key"];
            Console.WriteLine($"value of D1Key = {val}");

            ConfigurationRoot configRoot = (ConfigurationRoot)config;
            Console.WriteLine(configRoot.GetDebugView());
        }

        private Stream MakeJsonStreamConfig()
        {
            MemoryStream stream = new MemoryStream();

            JsonWriterOptions options = new JsonWriterOptions();
            options.Indented = true;

            using (Utf8JsonWriter writer = new Utf8JsonWriter(stream, options))
            {
                writer.WriteStartObject();
                writer.WriteString("AKey", "AVal");
                writer.WriteString("BKey", "BVal");
                writer.WriteStartObject("CSect");
                writer.WriteString("C1Key", "C1Val");
                writer.WriteEndObject();
                writer.WriteStartArray("DArr");
                writer.WriteStartObject();
                writer.WriteString("D1Key", "D1Val");
                writer.WriteEndObject();
                writer.WriteEndArray();
                writer.WriteEndObject();
                writer.Flush();
            }

            stream.Position = 0L;
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine(reader.ReadToEnd());
            stream.Position = 0L;
            return stream;
        }
    }
}
