using System;

using Microsoft.Extensions.Configuration;

using R5T.Norsica.Standard;


namespace R5T.Smyni.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddVisualStudioFileOperatorConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddDotnetConfiguration(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
