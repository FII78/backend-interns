using backend_interns.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace backend_interns.Services;

public class MongoDBService {

    private readonly IMongoCollection<Blogs> _blogsCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings) {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _blogsCollection = database.GetCollection<Blogs>(mongoDBSettings.Value.CollectionName);
    }
 
    public async Task<List<Blogs>> GetAsync() {
         return await _blogsCollection.Find(new BsonDocument()).ToListAsync();
     }

    public async Task<Blogs> GetbyIdAsync(string id){
        var filter = Builders<Blogs>.Filter.Eq(r => r.Id, id);
        return await _blogsCollection.Find(filter).FirstOrDefaultAsync();
    }
    public async Task CreateAsync(Blogs blogs) { 
        await _blogsCollection.InsertOneAsync(blogs);
        return;
    }

    public async Task DeleteAsync(string id) {
        FilterDefinition<Blogs> filter = Builders<Blogs>.Filter.Eq("Id", id);
        await _blogsCollection.DeleteOneAsync(filter);
        return;
    }

    public async Task UpdatetagsAsync(string id, string tag) {
        var filter = Builders<Blogs>.Filter.Eq(blog => blog.Id, id);
        var update = Builders<Blogs>.Update.Set(blog => blog.tag, tag);

        await _blogsCollection.UpdateOneAsync(filter, update);
        return;
    }

}