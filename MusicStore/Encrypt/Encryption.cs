using System.Reflection;
using System.Windows; // Для MessageBox

namespace MusicStore.Encrypt
{
    public static class Encryption
    {
        public static IPluginCipher LoadCipher(string dllPath)
        {
            try
            {
                Assembly pluginAssembly = Assembly.LoadFrom(dllPath);
                
                foreach (Type type in pluginAssembly.GetTypes())
                {
                    if (typeof(IPluginCipher).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        return (IPluginCipher)Activator.CreateInstance(type);
                    }
                }
                
                MessageBox.Show("Не найден класс, реализующий IPluginCipher");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                return null;
            }
        }
        public static byte[] BinaryStringToBytes(string binaryString)
        {
            // Убедимся, что длина строки кратна 8 (1 байт = 8 бит)
            int length = binaryString.Length;
            int padLength = (8 - length % 8) % 8;
            binaryString = binaryString.PadLeft(length + padLength, '0');

            // Создаём массив байтов нужного размера
            int byteCount = binaryString.Length / 8;
            byte[] bytes = new byte[byteCount];

            // Конвертируем каждые 8 бит в байт
            for (int i = 0; i < byteCount; i++)
            {
                string byteString = binaryString.Substring(i * 8, 8);
                bytes[i] = Convert.ToByte(byteString, 2); // 2 означает двоичную систему
            }

            return bytes;
        }
    }
}