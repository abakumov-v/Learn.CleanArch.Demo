using CleanArch.Application.Mappings;

namespace CleanArch.UI.Mvc.Web.Configuration
{
    public static class AutomapperConfiguration
    {
        public static void RegisterAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperConfig));
            AutomapperConfig.RegisterMappings();
        }
    }
}
