using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace knockoutApp2.ViewModels
{
    public class AuthorViewModel
    {
        [JsonProperty(PropertyName ="id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName ="fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "biography")]
        public string Biography { get; set; }
    }
}
