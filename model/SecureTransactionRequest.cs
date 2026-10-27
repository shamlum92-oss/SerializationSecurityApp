using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationSecurityApp.Models
{
    public class SecureTransactionRequest
    {
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        [JsonConverter(typeof(StrictDecimalConverter))]
        public decimal Amount { get; set; }

        [JsonPropertyName("payload_metadata")]
        public string Metadata { get; set; } = string.Empty;
    }

    // Custom converter to ensure strict parsing and reject malformed/unauthorized types
    public class StrictDecimalConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDecimal();
            }
            
            if (reader.TokenType == JsonTokenType.String)
            {
                string? stringValue = reader.GetString();
                if (decimal.TryParse(stringValue, out decimal result))
                {
                    return result;
                }
            }

            throw new JsonException("Invalid format or unauthorized type detected for decimal field.");
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}