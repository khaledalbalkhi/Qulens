using System;
using Microsoft.AspNetCore.Mvc;
using Qulens.Models;
using Qulens.DAL;

namespace Qulens.Controllers;

public class PostController : Controller
{
    private readonly IPostRepository _postRepository;
    public PostController(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }
    public async Task<IActionResult> PostIndex()
    {
        var posts = await _postRepository.GetAll();
        return View(posts);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Post post)
    {
        if (ModelState.IsValid)
        {
            post.CreatedAt = DateTime.Now;
            await _postRepository.Create(post);
            return RedirectToAction("PostIndex");
        }
        return View(post);
    }
}

