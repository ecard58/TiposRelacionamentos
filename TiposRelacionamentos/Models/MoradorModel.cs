﻿using System.Text.Json.Serialization;

namespace TiposRelacionamentos.Models
{
    public class MoradorModel
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        [JsonIgnore]
        public List<CasaModel> Casas {  get; set; }
    }
}
