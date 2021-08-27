using System;
using Newtonsoft.Json;

namespace PeopleAPI.Models
{
    public class People
    {
        [JsonProperty(PropertyName = "person")]
        public Person Person { get; set; }
    }

    public class Person
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        [JsonProperty(PropertyName = "interests")]
        public string[] Interests { get; set; }
        [JsonProperty(PropertyName = "image")]
        public byte[] Image { get; set; }
    }

    public class Address
    {
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "zip")]
        public int Zip { get; set; }
    }

}