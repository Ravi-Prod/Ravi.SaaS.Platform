namespace Identity.API.Entities;

public class RolePermission
    {
    public string RoleId { get; set; } = "";

    public Guid PermissionId { get; set; }
    }