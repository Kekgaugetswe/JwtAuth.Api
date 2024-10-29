using System;

namespace JwtAuth.Domain.Models.DTO;

public class UserResponseDto
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } =  string.Empty;
    public List<string> Roles { get; set; }  = new List<string>();
}


