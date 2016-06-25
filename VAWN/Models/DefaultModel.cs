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
        /// 
        /// </summary>
        [JsonProperty("DefaultId")]
        [XmlElement(ElementName = "DefaultId")]
        [Required]
        public System.Int32 DefaultId { get; set; }
        #endregion
    }
}