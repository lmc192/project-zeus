using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectZeus.Database;
using ProjectZeus.Database.Model;

namespace ProjectZeus.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Deity> Deities { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var context = new ZeusContext();
            Deities= new List<Deity>();
            var deityList = context.Deities.Include(d => d.Mythology).OrderBy(d => d.Name);
            foreach (var deity in deityList)
            {
                Deities.Add(deity);
            }
        }
    }
}
