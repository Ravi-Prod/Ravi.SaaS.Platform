namespace Identity.API.Entities;

public class Permission
    {
    public Guid Id { get; set; }

    public string Module { get; set; } = "";

    public string Action { get; set; } = "";

    public string Code { get; set; } = "";
    }