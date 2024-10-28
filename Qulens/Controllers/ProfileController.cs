using System;
using Microsoft.AspNetCore.Mvc;
using Qulens.Models;
using Qulens.DAL;

namespace Qulens.Controllers;

public class ProfileController : Controller
{
    private readonly IProfileRepository _profileRepository;

    public ProfileController(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    
    public async Task<IActionResult> ProfIndex()
    {
        var profiles = await _profileRepository.GetAll();
        return View(profiles);
    }
    
}
