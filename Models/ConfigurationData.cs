using System;

namespace src.Models
{
    public class ConfigurationData
    {
        private readonly static string _defaultStringValue = @"Value not readed from Config Store";
        public string AuthenticationProvider { get; set;} = _defaultStringValue;
        public string ServiceDiscoveryUri { get; set; } = _defaultStringValue;
        public string DotNetConfSantiagoEdition { get; set; } = _defaultStringValue; 
    }
}