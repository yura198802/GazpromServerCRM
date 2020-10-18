using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Monica.Core.DbModel.IdentityModel;
using Monica.Core.DbModel.Localization.Identity;
using Monica.Core.DbModel.ModelCrm;

namespace Monica.Core.DbModel.Extension
{
    public static class DbContextExtensions
    {
        public static void AddDbContextCore(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
        }
    }
}
