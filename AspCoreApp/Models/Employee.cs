using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspCoreApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Skills { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Employee>(this);

    }
}
