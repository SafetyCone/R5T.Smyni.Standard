using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Norsica.Standard;
using R5T.Smyni.Norsica;


namespace R5T.Smyni.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddVisualStudioFileOperator(this IServiceCollection services)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileOperator, DotnetVisualStudioSolutionFileOperator>()
                .AddDotnetOperator()
                ;

            return services;
        }
    }
}
