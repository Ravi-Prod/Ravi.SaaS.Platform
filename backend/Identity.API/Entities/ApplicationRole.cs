using Microsoft.AspNetCore.Identity;

namespace Identity.API.Entities;

public class ApplicationRole : IdentityRole
    {
    public string Description { get; set; } = "";
    }