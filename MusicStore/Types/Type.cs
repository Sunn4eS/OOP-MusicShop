using System.Reflection;

namespace MusicStore.Types;
    public static class Type
    {
        public static System.Type[] GetTypes()
        {
            Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            System.Type[] allTypes = allAssemblies
                .SelectMany(assembly =>
                {
                    try
                    {
                        return assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        return ex.Types.Where(t => t != null);
                    }
                })
                .ToArray()!;
            return allTypes;
        }
    }