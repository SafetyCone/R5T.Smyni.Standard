using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Norsica.Standard;
using R5T.Smyni.Default;
using R5T.Smyni.Norsica;


namespace R5T.Smyni.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddVisualStudioSolutionFileOperator(this IServiceCollection services)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileOperator, DotnetVisualStudioSolutionFileOperator>()
                .AddDotnetOperator()
                .AddSingleton<IVisualStudioSolutionFilePathProvider, VisualStudioSolutionFilePathProvider>()
                .AddSingleton<IStringlyTypedPathOperator, StringlyTypedPathOperator>()
                .AddSingleton<IFileNameOperator, FileNameOperator>()
                ;

            return services;
        }
    }
}
