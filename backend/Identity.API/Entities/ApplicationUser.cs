using Microsoft.AspNetCore.Identity;

namespace Identity.API.Entities;

public class ApplicationUser : IdentityUser
    {
    public Guid TenantId { get; set; }

    public Guid BranchId { get; set; }

    public string FullName { get; set; } = "";
    }