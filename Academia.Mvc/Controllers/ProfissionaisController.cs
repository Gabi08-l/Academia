using Microsoft.AspNetCore.Authorization;

namespace Academia;

[Authorize(Roles = "Admin")]
public class ProfissionaisController
{
    
}