using ConsoleApp2.ConfigurationSources;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ConfigurationExtensions
{
    internal static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddCsvFile(
            this IConfigurationBuilder builder,
            IFileProvider? fileProvider,
            string path,
            bool optional,
            bool reloadOnChanged
        )
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("path");
            }

            return builder.Add<CsvConfigurationSource>(s =>
            {
                s.FileProvider = fileProvider;
                s.Path = path;
                s.Optional = optional;
                s.ReloadOnChange = reloadOnChanged;
            });
        }

        public static IConfigurationBuilder AddCsvFile(
            this IConfigurationBuilder builder,
            string path
        )
        {
            return builder.AddCsvFile(
                null,
                path,
                false,
                false
            );
        }
    }
}
