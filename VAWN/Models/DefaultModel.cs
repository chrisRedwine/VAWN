using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VAWN.Models
{
    public partial class DefaultModel
    {
        #region Instance Properties
        /// <summary>
        /// UserName
        /// </summary>
        [JsonProperty("UserName")]
        [XmlElement(ElementName = "UserName")]
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// UserDomainName
        /// </summary>
        [JsonProperty("UserDomainName")]
        [XmlElement(ElementName = "UserDomainName")]
        [Required]
        public string UserDomainName { get; set; }

        /// <summary>
        /// MachineName
        /// </summary>
        [JsonProperty("MachineName")]
        [XmlElement(ElementName = "MachineName")]
        [Required]
        public string MachineName { get; set; }

        /// <summary>
        /// OSVersionString
        /// </summary>
        [JsonProperty("OSVersionString")]
        [XmlElement(ElementName = "OSVersionString")]
        [Required]
        public string OSVersionString { get; set; }
        #endregion
    }
}