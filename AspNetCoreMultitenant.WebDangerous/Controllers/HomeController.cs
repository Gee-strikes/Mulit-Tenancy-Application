using System.Diagnostics;
using System.Linq;
using AspNetCoreMultitenant.WebDangerous.Data;
using AspNetCoreMultitenant.WebDangerous.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMultitenant.WebDangerous.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITenantProvider _tenantProvider;

        public HomeController(ApplicationDbContext context,
                              ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }
    }
}
