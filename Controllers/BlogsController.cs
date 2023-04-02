using System;
using Microsoft.AspNetCore.Mvc;
using backend_interns.Services;
using backend_interns.Models;

namespace backend_interns.Controllers; 

[Controller]
[Route("api/[controller]")]
public class BlogsController: Controller {
    
    private readonly MongoDBService _mongoDBService;

    public BlogsController(MongoDBService mongoDBService) {
        _mongoDBService = mongoDBService;
    }

    [HttpGet]
    public async Task<List<Blogs>> Get() {
        return await _mongoDBService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Blogs> GetbyId(string id) {
        return await _mongoDBService.GetbyIdAsync(id);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Blogs blogs) {
        await _mongoDBService.CreateAsync(blogs);
        return CreatedAtAction(nameof(Get), new { id = blogs.Id }, blogs);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Updatebytags(string id, [FromBody] string tag) {
        await _mongoDBService.UpdatetagsAsync(id, tag);
        return NoContent();
        
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id) {
        await _mongoDBService.DeleteAsync(id);
        return NoContent();
    }

}