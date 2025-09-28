using Microsoft.AspNetCore.Identity;

namespace ClinicaApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Relacionamento 1-1 com Profissional
        public virtual Profissional Profissional { get; set; }
    }
}
