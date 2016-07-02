using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VAWN.Models
{
    public partial class MovieModel
    {
        #region Instance Properties
        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("Title")]
        [XmlElement(ElementName = "Title")]
        [Required]
        public string Title { get; set; }
        
        /// <summary>
        /// Tagline
        /// </summary>
        [JsonProperty("Tagline")]
        [XmlElement(ElementName = "Tagline")]
        [Required]
        public string Tagline { get; set; }

        /// <summary>
        /// Released
        /// </summary>
        [JsonProperty("Released")]
        [XmlElement(ElementName = "Released")]
        [Required]
        public string Released { get; set; }
        #endregion
    }
}