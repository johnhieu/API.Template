namespace API.Template
{
    using API.Interface;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Web.Http;
    using Unity;
    using Unity.AspNet.WebApi;
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // init working directory
            string workingDirectory = AppDomain.CurrentDomain.RelativeSearchPath;
            // init prefix for searching
            // For the time being, use the code to extract CARM exclusively
            string prefix = $"{workingDirectory}\\{typeof(WebApiConfig).Assembly.GetName().Name.Split('.')[0]}";
           
            // get all dll assemblies
            var assemblies = Directory.GetFiles(workingDirectory)
                                    .Where(x => x.StartsWith(prefix) && x.EndsWith(".dll"))
                                    .Select(Assembly.LoadFrom)
                                    .ToList();
            // call Register for each project
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes()
                                    .Where(x => x.GetInterface(typeof(IStartup).Name) != null && x.IsClass)
                                    .ToList();
                types.ForEach(x =>
                {
                    var startup = Activator.CreateInstance(x, container) as IStartup;
                    startup?.Register();
                });
            }


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}