using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentManagement.Infrastructure.Seeders
{
    public class ApplicationSeeder(ISkillSeeder skillSeeder) : IApplicationSeeder
    {
        public async Task SeedAllAsync()
        {
            await skillSeeder.SeedAsync();
        }
    }
}
