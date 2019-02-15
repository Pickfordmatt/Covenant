// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DotNetVersion.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DotNetVersion
    {
        [EnumMember(Value = "Net40")]
        Net40,
        [EnumMember(Value = "Net35")]
        Net35,
        [EnumMember(Value = "NetCore21")]
        NetCore21
    }
    internal static class DotNetVersionEnumExtension
    {
        internal static string ToSerializedValue(this DotNetVersion? value)
        {
            return value == null ? null : ((DotNetVersion)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DotNetVersion value)
        {
            switch( value )
            {
                case DotNetVersion.Net40:
                    return "Net40";
                case DotNetVersion.Net35:
                    return "Net35";
                case DotNetVersion.NetCore21:
                    return "NetCore21";
            }
            return null;
        }

        internal static DotNetVersion? ParseDotNetVersion(this string value)
        {
            switch( value )
            {
                case "Net40":
                    return DotNetVersion.Net40;
                case "Net35":
                    return DotNetVersion.Net35;
                case "NetCore21":
                    return DotNetVersion.NetCore21;
            }
            return null;
        }
    }
}