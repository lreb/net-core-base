using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Base.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

    }
}
