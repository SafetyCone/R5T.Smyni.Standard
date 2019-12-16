using System;

using Microsoft.Extensions.Configuration;

using R5T.Norsica.Standard;


namespace R5T.Smyni.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddVisualStudioSolutionFileOperatorConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddDotnetConfiguration(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
