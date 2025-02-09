using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ConfigurationProviders
{
    internal class CsvConfigurationProvider : FileConfigurationProvider
    {
        public CsvConfigurationProvider(FileConfigurationSource source) : base(source)
        {
        }

        public override void Load(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                string? keyLine = reader.ReadLine();
                string? valLine = reader.ReadLine();

                if (string.IsNullOrEmpty(keyLine) || string.IsNullOrEmpty(valLine))
                {
                    throw new FormatException();
                }

                string[] keys = keyLine.Split(',');
                string[] vals = valLine.Split(",");

                if (keys.Length != vals.Length)
                {
                    throw new FormatException();
                }

                for (int i = 0; i < keys.Length; i++)
                {
                    string key = keys[i];
                    string val = vals[i];
                    Data.Add(key, val);
                }
            }
        }
    }
}
