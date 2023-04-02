using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace backend_interns.Models;

public class Blogs {

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("title")]
    [JsonPropertyName("title")]
    public string blogTitle { get; set; } = null!;
    public string author { get; set; } = null!;
    public string content { get; set; } = null!;
    public string tag { get; set; } = null!;

}