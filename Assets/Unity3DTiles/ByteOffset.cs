using System.Text.Json.Serialization;

    public class ByteOffset
    {
        [JsonPropertyName("byteOffset")]
        public int byteOffset { get; set; }

        public string componentType { get; set; }
    }