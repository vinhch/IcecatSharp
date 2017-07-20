using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using IcecatSharp.Infrastructure;

namespace IcecatSharp.Tests
{
    public static class Utils
    {
        private static IConfigurationRoot _configuration;
        public static IConfigurationRoot Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile("appsettings.private.json", optional: true);
                    //.AddEnvironmentVariables();

                    _configuration = builder.Build();
                }
                return _configuration;
            }
        }

        private static IceCatAccessConfig _iceCatConfig;
        public static IceCatAccessConfig IceCatConfig
        {
            get
            {
                if (_iceCatConfig == null)
                {
                    var authState = new IceCatAccessConfig();
                    Configuration.GetSection("IceCatConfig").Bind(authState);
                    _iceCatConfig = authState;
                }

                if (string.IsNullOrEmpty(_iceCatConfig.Username) || string.IsNullOrEmpty(_iceCatConfig.Password))
                {
                    throw new Exception($"{nameof(IceCatAccessConfig)} was not initialize.");
                }

                return _iceCatConfig;
            }
        }
    }
}
