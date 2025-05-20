using System.Reflection;
using MusicStore.Instruments;

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
        public static List<System.Type> GetKnownInstrumentTypes()
        {
            return GetTypes()
                .Where(t => typeof(MusicalInstrument).IsAssignableFrom(t) && !t.IsAbstract)
                .ToList();
        }
    }